using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Assessment
{
    public partial class Default : System.Web.UI.Page
    {
        #region Variables
        protected bool isNumber;
        protected int output;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            lblList.Text = string.Join(" , ", Constants.Intergers);
        }

        /// <summary>
        /// get 3 sides of a triangle and specifies the type
        /// </summary>
        /// <param name="_sideA">side A</param>
        /// <param name="_sideB">side B</param>
        /// <param name="_sideC">side C</param>
        /// <returns>type of triangle from Enums.TriangleType enum</returns>
        protected Enums.TriangleType GetTriangleType(int _sideA, int _sideB, int _sideC)
        {
            if (_sideA == _sideB && _sideB == _sideC)
            {
                return Enums.TriangleType.Equilateral;
            }
            else if (_sideA == _sideB || _sideA == _sideC || _sideB == _sideC)
            {
                return Enums.TriangleType.Isosceles;
            }
            else
            {
                return Enums.TriangleType.Scalene;
            }
        }

        /// <summary>
        /// check if a string is numeric
        /// </summary>
        /// <param name="_value">value to check</param>
        /// <returns>if a value is numberic</returns>
        protected bool IsNumberic(string _value)
        {
            return int.TryParse(_value, out output);
        }

        /// <summary>
        /// reverse a string
        /// </summary>
        /// <param name="_value">value to reverse</param>
        /// <returns> reversed value</returns>
        protected string Reverse(string _value)
        {
            return new string(_value.ToCharArray().Reverse().ToArray());
        }

        /// <summary>
        /// returns 5th element in a list from the end
        /// </summary>
        /// <param name="_list">list of integers</param>
        /// <param name="_order">order from the end of list</param>
        /// <returns>nth element in a list</returns>
        protected int GetNth(List<int> _list, int _order)
        {
            return _list.ElementAt(_list.Count - _order);
        }

        /// <summary>
        /// show result or error message
        /// </summary>
        /// <param name="_labelResult">label to show result</param>
        /// <param name="_labelError">label to show error</param>
        /// <param name="_message">error message</param>
        protected void ShowMessage(Label _labelResult, Label _labelError ,string _message)
        {
            _labelError.Visible = !(_message.Trim() == string.Empty);
            _labelResult.Visible = !_labelError.Visible;
            _labelError.Text = _message;
        }

        protected void btnTriangleType_Click(object sender, EventArgs e)
        {
            try
            {
                ShowMessage(lblTriangleResult, lblTriangleError, string.Empty);

                if (txtSideA.Text.Length > 10 || txtSideB.Text.Length > 10 || txtSideC.Text.Length > 10)
                {
                    ShowMessage(lblTriangleResult, lblTriangleError, "Maximum number length is 10 digits.");
                    return;
                }
                else if (!IsNumberic(txtSideA.Text.Trim()) || !IsNumberic(txtSideB.Text.Trim()) || !IsNumberic(txtSideC.Text.Trim()))
                {
                    ShowMessage(lblTriangleResult, lblTriangleError, "One or more values are not numberic");
                    return;
                }

                lblTriangleResult.Text = GetTriangleType(Convert.ToInt32(txtSideA.Text), Convert.ToInt32(txtSideB.Text), Convert.ToInt32(txtSideC.Text)).ToString();
            }

            catch (Exception ex)
            {
                ShowMessage(lblTriangleResult, lblTriangleError, ex.Message);
            }
        }

        protected void btnReverse_Click(object sender, EventArgs e)
        {
            ShowMessage(lblReverseResult, lblReverseError, string.Empty);

            if (txtSentence.Text.Trim() == string.Empty)
            {
                ShowMessage(lblReverseResult, lblReverseError, "Please enter a sentence.");
                return;
            }
            try
            {
                lblReverseResult.Text = Reverse(txtSentence.Text);
            }

            catch (Exception ex)
            {
                ShowMessage(lblReverseResult, lblReverseError, ex.Message);
            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                lblListResult.Text = GetNth(Constants.Intergers, 5).ToString();
                ShowMessage(lblListResult, lblReverseError, string.Empty);
            }

            catch (Exception ex)
            {
                ShowMessage(lblListResult, lblReverseError, ex.Message);
            }
        }
    }
}