using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Manual_Inspection
{
    public partial class Form1 : Form
    {
        string[] filenames;
        string selectedFileName;
        int newX=0, newY=0;//kép adott pixelének pontos mérete
       
        bool draw = false;
        LineSegment2D[] seg;
        LineSegment2D[] selSeg;
        Point p1, p2;

        Image<Gray, byte> imgGray,roiImage;
        Point roiStartPoint= new Point(0,0), roiEndPoint = new Point(0,0);
        static Point mousecord;//egér jelenlegi helye
        Rectangle roiRec;
        List<ROIs> roiList2 = new List<ROIs>();
        List<ROIs> patternROIList = new List<ROIs>();
        List<Segments> roiSegmentList = new List<Segments>();
        List<Image<Gray, byte>> roiImageList = new List<Image<Gray, byte>>();
        Pen penDef = new Pen(Color.Cyan, 2);
        Pen penRed = new Pen(Color.Red, 3);
        Pen penPattern = new Pen(Color.Orange, 3);
        int newROIWidthSIze=0, newROIHeightSIze=0;
        bool inspectRun=false;
        int thres, cAnny;
        int rho, minLineLength, maxGap;
        int newROIWidth = 100,newROIHeight = 100;
        bool roiMoveIsActive = false;
        ROIs selectedROI;//combobox kiválaztott ROI-ja
        int inspectPercent = 50;
        //=========Pattern========
        bool drawPaternRect = false;
        Image<Gray, byte> imgPattern;
        Rectangle patternRect;
        //========EndPattern======
        Image<Gray, Byte> ThreshImg;


        struct ROIs
        {
            public String name;
            public Rectangle recSize;
        };
        struct Segments
        {
            public String name;
            public LineSegment2D[] segment;
        };


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (selectedROIComboBox.SelectedIndex>-1)
            {
                roiList2.RemoveAt(selectedROIComboBox.SelectedIndex);
                selectedROIComboBox.Items.RemoveAt(selectedROIComboBox.SelectedIndex);
                if (roiList2.Count>0)
                {
                    selectedROIComboBox.SelectedIndex = 0;
                }              
                ManualDrawPicBox1();
            }
        }

  
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    mousecord = e.Location;//adott egér pozija
                    roiStartPoint.X = mousecord.X - (newROIWidth / 2);//pozi átadása ROI strt pontnak
                    roiStartPoint.Y = mousecord.Y - newROIHeight / 2;
                    roiEndPoint.X = mousecord.X + newROIWidth;
                    roiEndPoint.Y = mousecord.Y + newROIHeight;//ROI endpoint kiszámítása a saztzpontból és a méretből
                    ROIs r1,rPattern;                                     
                    if (drawPaternRect&&ThreshImg!=null)
                    {
                        patternRect = roiRec = new Rectangle(mousecord.X - (int)patternWidthNumeric.Value/2, mousecord.Y-(int)patternHeightNumeric.Value/2, (int)patternWidthNumeric.Value, (int)patternHeightNumeric.Value);//
                        patternROIList.Clear();
                        rPattern.name = roiList2.Count.ToString() + "_PatternROI";
                        rPattern.recSize = patternRect;
                        patternROIList.Add(rPattern);
                        
                        ThreshImg.ROI = roiRec;
                        imgPattern = ThreshImg.Clone();
                        ThreshImg.ROI = Rectangle.Empty;
                        pictureBox2.Image = imgPattern.ToBitmap(); //imgPattern.ToBitmap();
                        deletePatternImage.Enabled = true;
                    }
                    if (addROIchk.Checked)
                    {                                        
                        roiRec = new Rectangle(roiStartPoint.X, roiStartPoint.Y, newROIWidth, newROIHeight);//kezdőpont X,Y, méret X,Y                    
                        r1.name = roiList2.Count.ToString() + "_ROI";
                        r1.recSize = roiRec;
                        roiList2.Add(r1);
                         selectedROIComboBox.Items.Clear();
                        //selectedROIComboBox.DataSource = roiList2.ToString() ;
                        foreach (var item in roiList2)
                        {
                            selectedROIComboBox.Items.Add(item.name);
                        }
                        if (selectedROIComboBox.Items.Count>0)
                        {
                            selectedROIComboBox.SelectedIndex = 0;
                        }                  
                    }

                   

                    ManualDrawPicBox1();
                    break;
                case MouseButtons.Right:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    MessageBox.Show(e.Button.ToString());
                    break;
                case MouseButtons.XButton2:
                    MessageBox.Show(e.Button.ToString());
                    break;
                default:
                    MessageBox.Show(e.Button.ToString());
                    break;
            }

           
           
        }


        private void ManualDrawPicBox1()
        {
            draw = true;
            pictureBox1.Refresh();
            draw = false;
        }
       

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {            
            if (draw)
            {            
               foreach (var item in roiList2)//ROI rajzolás
                {
                    e.Graphics.DrawString(item.name, new Font("Arial", 12,FontStyle.Bold), new SolidBrush(Color.Red), new Point(item.recSize.Location.X, item.recSize.Location.Y - 20));
                    e.Graphics.DrawRectangle(penDef, item.recSize);
                }
                if (roiSegmentList.Count>0)//Segment kirajzolás
                {                 
                    for (int i = 0; i < roiSegmentList.Count; i++)
                    {
                        Point tmpROIStartPos = new Point( roiList2[i].recSize.X, roiList2[i].recSize.Y);
                        int tmpROISizeWidth = roiList2[i].recSize.Width;
                        int tmpROISizeHeight = roiList2[i].recSize.Height;
                        
                        for (int j = 0; j < roiSegmentList[i].segment.Length; j++)
                        {
                            p1 = new Point(roiSegmentList[i].segment[j].P1.X + tmpROIStartPos.X, roiSegmentList[i].segment[j].P1.Y + tmpROIStartPos.Y);
                            p2 = new Point(roiSegmentList[i].segment[j].P2.X + tmpROIStartPos.X, roiSegmentList[i].segment[j].P2.Y + tmpROIStartPos.Y);
                            e.Graphics.DrawLine(penRed, p1.X, p1.Y, p2.X, p2.Y);
                        }
                    }
                }

                foreach (var item in patternROIList)
                {
                    e.Graphics.DrawString(item.name, new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Orange), new Point(item.recSize.Location.X, item.recSize.Location.Y - 20));
                    e.Graphics.DrawRectangle(penPattern, roiRec);
                }
                drawPaternRect = false;

            }
           
            /*if (drawPaternRect)
            {
                foreach (var item in patternROIList)
                {
                    e.Graphics.DrawString(item.name, new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Red), new Point(item.recSize.Location.X, item.recSize.Location.Y - 20));
                    e.Graphics.DrawRectangle(penPattern, roiRec);
                }
                

                drawPaternRect = false;
               
            }*/
        }

        public Form1()
        {
            InitializeComponent();
            selAnalizeTypeCombo.SelectedIndex = 0;
            resultDataGrid.ColumnCount = 3;
            resultDataGrid.Columns[0].Name = "ROI";
            resultDataGrid.Columns[1].Name = "Result";
            resultDataGrid.Columns[2].Name = "Percent";
        }





        private void SelROISizeSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                newROIWidthSIze = Convert.ToInt32(selROIwidthText.Text);
                newROIHeightSIze = Convert.ToInt32(selROIHeightText.Text);
                for(int i=0; i<roiList2.Count;i++)
                {
                    if (roiList2[i].name == selectedROI.name)
                    {
                        if (roiList2[i].recSize.Width != newROIWidthSIze || roiList2[i].recSize.Height != newROIHeightSIze)
                        {
                            string name = selectedROI.name;
                            Rectangle new1 = new Rectangle(
                                selectedROI.recSize.X,
                                selectedROI.recSize.Y,
                                newROIWidthSIze,
                                newROIHeightSIze);
                            ROIs n;
                            n.name = name;
                            n.recSize = new1;
                            roiList2[i] = n;
                            ManualDrawPicBox1();
                            break;
                        }                       
                    }                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem lehet konvertálni!\nAlap szám: 10");
            }

           
           /* if (newROIWidthSIze!=0&& newROIHeightSIze!=0&& selectedROIComboBox.SelectedIndex!=-1)
            {
                string name = roiList2[selectedROIComboBox.SelectedIndex].name;
                Rectangle new1 = new Rectangle(
                    roiList2[selectedROIComboBox.SelectedIndex].recSize.X,
                    roiList2[selectedROIComboBox.SelectedIndex].recSize.Y,
                    newROIWidthSIze,
                    newROIHeightSIze);
                ROIs n;
                n.name = name;
                n.recSize = new1;
                roiList2[selectedROIComboBox.SelectedIndex] = n;

                draw = true;
                pictureBox1.Refresh();
                draw = false;
            }*/
        }



        private void minLineLengthNumText_ValueChanged(object sender, EventArgs e)
        {
            if ((int)minLineLengthNumText.Value < 0)
            {
                minLineLengthNumText.Value = 0;
            }
            if ((int)minLineLengthNumText.Value > 255)
            {
                minLineLengthNumText.Value = 255;
            }
            minLineLength = (int)minLineLengthNumText.Value;
        }


        private void fileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFileName = filenames[fileListBox.SelectedIndex];
            roiSegmentList.Clear();
            roiImageList.Clear();
            pictureBox1.Refresh();
            imgGray = new Image<Gray, byte>(selectedFileName);
            Size s = new Size(pictureBox1.Width, pictureBox1.Height);
            imgGray = imgGray.Resize(s.Width, s.Height, Emgu.CV.CvEnum.Inter.Linear);
            pictureBox1.Image = imgGray.ToBitmap();
            ManualDrawPicBox1();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Right:
                    for (int i = 0; i < roiList2.Count; i++)
                    {
                        if (roiList2[i].name==selectedROI.name&&
                            mousecord.X>roiList2[i].recSize.X&&
                            mousecord.X< roiList2[i].recSize.X+ roiList2[i].recSize.Width&&
                            mousecord.Y > roiList2[i].recSize.Y &&
                            mousecord.Y < roiList2[i].recSize.Y + roiList2[i].recSize.Height)
                        {
                            roiMoveIsActive = true;
                            break;
                        }
                    }
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
            
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Right:
                    roiMoveIsActive = false;                   
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
            
        }
        private void maxGapNumText_ValueChanged(object sender, EventArgs e)
        {
            if ((int)maxGapNumText.Value < 0)
            {
                maxGapNumText.Value = 0;
            }
            if ((int)maxGapNumText.Value > 255)
            {
                maxGapNumText.Value = 255;
            }
            maxGap = (int)maxGapNumText.Value;
        }

  

        private void selectedROIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//ha megváltozik a roi combó értéke, akkor kérje le annak az ROI-nak az értékeit és töltse bele a változókba
            if (selectedROIComboBox.Text!="")
            {
                foreach (var item in roiList2)
                {
                    if (item.name==selectedROIComboBox.Text)
                    {
                        selectedROI = item;
                        selROIHeightText.Text = item.recSize.Height.ToString();
                        selROIwidthText.Text = item.recSize.Width.ToString();
                        break;
                    }
                }
            }
        }



        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            mainThresholdValueLabel.Text = thresholdTrackBar.Value.ToString();
            if (imgGray!=null)
            {
                if (ThreshImg!=null)
                {
                    ThreshImg.ROI = Rectangle.Empty;
                }
                
                imgGray = imgGray.Resize(pictureBox1.Size.Width, pictureBox1.Size.Height, Emgu.CV.CvEnum.Inter.Linear);

                ThreshImg = imgGray.ThresholdBinary(new Gray(thresholdTrackBar.Value), new Gray(255));
                    pictureBox1.Image = ThreshImg.ToBitmap();
                    ManualDrawPicBox1();
            }          
        }

        private void addPatternImage_Click(object sender, EventArgs e)
        {
             drawPaternRect = true;
        }

        private void deletePatternImage_Click(object sender, EventArgs e)
        {
            if (patternROIList.Count>0)
            {
                addPatternImage.Enabled = true;
                deletePatternImage.Enabled = false;
                patternROIList.Clear();
                ManualDrawPicBox1();
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                inspectPercent = (int)numericUpDown1.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /*  public void PerformShapeDetection()
          {
              if (fileNameTextBox.Text != String.Empty)
              {
                  StringBuilder msgBuilder = new StringBuilder("Performance: ");

                  //Load the image from file and resize it for display
                  Image<Bgr, Byte> img =
                     new Image<Bgr, byte>(fileNameTextBox.Text)
                     .Resize(400, 400, Emgu.CV.CvEnum.Inter.Linear, true);

                  //Convert the image to grayscale and filter out the noise
                  UMat uimage = new UMat();
                  CvInvoke.CvtColor(img, uimage, ColorConversion.Bgr2Gray);

                  //use image pyr to remove noise
                  UMat pyrDown = new UMat();
                  CvInvoke.PyrDown(uimage, pyrDown);
                  CvInvoke.PyrUp(pyrDown, uimage);

                  //Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

                  #region circle detection
                  Stopwatch watch = Stopwatch.StartNew();
                  double cannyThreshold = 180.0;
                  double circleAccumulatorThreshold = 120;
                  CircleF[] circles = CvInvoke.HoughCircles(uimage, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);

                  watch.Stop();
                  msgBuilder.Append(String.Format("Hough circles - {0} ms; ", watch.ElapsedMilliseconds));
                  #endregion

                  #region Canny and edge detection
                  watch.Reset(); watch.Start();
                  double cannyThresholdLinking = 120.0;
                  UMat cannyEdges = new UMat();
                  CvInvoke.Canny(uimage, cannyEdges, cannyThreshold, cannyThresholdLinking);

                  LineSegment2D[] lines = CvInvoke.HoughLinesP(
                     cannyEdges,
                     1, //Distance resolution in pixel-related units
                     Math.PI / 45.0, //Angle resolution measured in radians.
                     20, //threshold
                     30, //min Line width
                     10); //gap between lines

                  watch.Stop();
                  msgBuilder.Append(String.Format("Canny & Hough lines - {0} ms; ", watch.ElapsedMilliseconds));
                  #endregion

                  #region Find triangles and rectangles
                  watch.Reset(); watch.Start();
                  List<Triangle2DF> triangleList = new List<Triangle2DF>();
                  List<RotatedRect> boxList = new List<RotatedRect>(); //a box is a rotated rectangle

                  using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
                  {
                      CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                      int count = contours.Size;
                      for (int i = 0; i < count; i++)
                      {
                          using (VectorOfPoint contour = contours[i])
                          using (VectorOfPoint approxContour = new VectorOfPoint())
                          {
                              CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                              if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours with area greater than 250
                              {
                                  if (approxContour.Size == 3) //The contour has 3 vertices, it is a triangle
                                  {
                                      Point[] pts = approxContour.ToArray();
                                      triangleList.Add(new Triangle2DF(
                                         pts[0],
                                         pts[1],
                                         pts[2]
                                         ));
                                  }
                                  else if (approxContour.Size == 4) //The contour has 4 vertices.
                                  {
                                      #region determine if all the angles in the contour are within [80, 100] degree
                                      bool isRectangle = true;
                                      Point[] pts = approxContour.ToArray();
                                      LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                                      for (int j = 0; j < edges.Length; j++)
                                      {
                                          double angle = Math.Abs(
                                             edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                          if (angle < 80 || angle > 100)
                                          {
                                              isRectangle = false;
                                              break;
                                          }
                                      }
                                      #endregion

                                      if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
                                  }
                              }
                          }
                      }
                  }

                  watch.Stop();
                  msgBuilder.Append(String.Format("Triangles & Rectangles - {0} ms; ", watch.ElapsedMilliseconds));
                  #endregion

                  originalImageBox.Image = img;
                  this.Text = msgBuilder.ToString();

                  #region draw triangles and rectangles
                  Mat triangleRectangleImage = new Mat(img.Size, DepthType.Cv8U, 3);
                  triangleRectangleImage.SetTo(new MCvScalar(0));
                  foreach (Triangle2DF triangle in triangleList)
                  {
                      CvInvoke.Polylines(triangleRectangleImage, Array.ConvertAll(triangle.GetVertices(), Point.Round), true, new Bgr(Color.DarkBlue).MCvScalar, 2);
                  }
                  foreach (RotatedRect box in boxList)
                  {
                      CvInvoke.Polylines(triangleRectangleImage, Array.ConvertAll(box.GetVertices(), Point.Round), true, new Bgr(Color.DarkOrange).MCvScalar, 2);
                  }

                  triangleRectangleImageBox.Image = triangleRectangleImage;
                  #endregion

                  #region draw circles
                  Mat circleImage = new Mat(img.Size, DepthType.Cv8U, 3);
                  circleImage.SetTo(new MCvScalar(0));
                  foreach (CircleF circle in circles)
                      CvInvoke.Circle(circleImage, Point.Round(circle.Center), (int)circle.Radius, new Bgr(Color.Brown).MCvScalar, 2);

                  circleImageBox.Image = circleImage;
                  #endregion

                  #region draw lines
                  Mat lineImage = new Mat(img.Size, DepthType.Cv8U, 3);
                  lineImage.SetTo(new MCvScalar(0));
                  foreach (LineSegment2D line in lines)
                      CvInvoke.Line(lineImage, line.P1, line.P2, new Bgr(Color.Green).MCvScalar, 2);

                  lineImageBox.Image = lineImage;
                  #endregion
              }
          }*/

        private void th_1()
        {
            roiSegmentList.Clear();            
            roiImageList.Clear();
            while (inspectRun)
            {
                imgGray.ROI = Rectangle.Empty;
                foreach (ROIs item in roiList2)
                {
                    imgGray.ROI = item.recSize;
                    Image<Gray, byte> cannyEdges = imgGray.Canny(cAnny, 255);
                     seg = CvInvoke.HoughLinesP(
                       cannyEdges,
                       1, //Distance resolution in pixel-related units
                       Math.PI / 45.0, //Angle resolution measured in radians.
                       thres, //threshold
                       minLineLength, //min Line width
                       maxGap); //gap between lines
                    Segments s;
                    s.name = roiSegmentList.Count.ToString();
                    s.segment = seg;
                    roiSegmentList.Add(s);
                    Thread.Sleep(1);
                }               
                inspectRun = false;
            }
            inspectONEPicture.Invoke((MethodInvoker)delegate
            {
                ManualDrawPicBox1();
            });
        }

        private void inspectPicture_Click(object sender, EventArgs e)
        {
            if (roiList2.Count>0)
            {                            
                Thread t1 = new Thread(new ThreadStart(th_1));
                t1.IsBackground = true;
                inspectRun = true;
                t1.Start();
            }
        }

        private void cannyNumText_ValueChanged(object sender, EventArgs e)
        {
            if ((int)cannyNumText.Value < 0)
            {
                cannyNumText.Value = 0;
            }
            if ((int)cannyNumText.Value > 255)
            {
                cannyNumText.Value = 255;
            }
            cAnny = (int)cannyNumText.Value;
        }

        private void thresholdNumText_ValueChanged(object sender, EventArgs e)
        {
            if ((int)thresholdNumText.Value < 0)
            {
                thresholdNumText.Value = 0;
            }
            if ((int)thresholdNumText.Value > 255)
            {
                thresholdNumText.Value = 255;
            }
            thres = (int)thresholdNumText.Value;
        }

 

        private void roiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedROIComboBox.SelectedIndex>-1)
            {
                deleteROIbtn.Enabled = true;
                selROIwidthText.Text = roiList2[selectedROIComboBox.SelectedIndex].recSize.Width.ToString();
                selROIHeightText.Text = roiList2[selectedROIComboBox.SelectedIndex].recSize.Height.ToString();
            }
            else
            {
                deleteROIbtn.Enabled = false;
            }           
        }



        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            /* if (resultDataGrid.SelectedRows.Count>0)
             {
                 pictureBox2.Image = roiImageList[resultDataGrid.CurrentCell.RowIndex].ToBitmap();
             }*/
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roiSegmentList.Clear();
            roiImageList.Clear();

            pictureBox1.Refresh();
            pictureBox2.Refresh();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filenames = dlg.FileNames;
                foreach (var item in filenames)
                {
                    fileListBox.Items.Add(item);
                    fileListBox.SelectedIndex = 0;
                }

               /* imgGray = new Image<Gray, byte>(filenames[fileListBox.SelectedIndex]);
                Size s = new Size(pictureBox1.Width, pictureBox1.Height);
                imgGray=imgGray.Resize(s.Width, s.Height, Emgu.CV.CvEnum.Inter.Area);
                pictureBox1.Image = imgGray.ToBitmap();*/
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
               mousecord = e.Location;
               if (imgGray != null && mousecord.X < imgGray.Width && mousecord.Y < imgGray.Height)
               {
                   float aranyszamX = (float)imgGray.Size.Width / (float)pictureBox1.Size.Width;
                   float aranyszamY = (float)imgGray.Size.Height / (float)pictureBox1.Size.Height;
                   newX = Convert.ToInt32(mousecord.X * aranyszamX);
                   newY = Convert.ToInt32(mousecord.Y * aranyszamY);

                   Gray gray = imgGray[newY, newX];
                   mainRGBValue.Text = gray.ToString();
                   mainCursorPos.Text = mousecord.ToString();
                }
               else
               {              
                   mainRGBValue.Text = "-";
                   mainCursorPos.Text = "-";
               }

            if (roiMoveIsActive)
            {
                ROIs r1;//új roi
                Rectangle tmpRec = new Rectangle(
                    mousecord.X - Convert.ToInt32(selROIwidthText.Text) / 2,
                    mousecord.Y - Convert.ToInt32(selROIwidthText.Text) / 2,
                    Convert.ToInt32(selROIwidthText.Text),
                    Convert.ToInt32(selROIHeightText.Text));//új pozi

                r1.name = roiList2[selectedROIComboBox.SelectedIndex].name;
                r1.recSize = tmpRec;

                roiList2[selectedROIComboBox.SelectedIndex] = r1;
                ManualDrawPicBox1();

            }
        }

    }
}
