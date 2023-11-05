using Leetcode;

namespace LeetCode.Tests;

public class ValidPalindrome_Should
{
    [Fact]
    public void Empty_Should_Return_True()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_Should_Return_True()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("A");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_a_Should_Return_True()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("Aa");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_b_Should_Return_False()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("Ab");
        var expected = false;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_b_a_Should_Return_True()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("Aba");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_b_c_Should_Return_False()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("Abc");
        var expected = false;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_b_b_a_Should_Return_True()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("Abba");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_b_c_b_a_Should_Return_True()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("Abcba");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void A_b_c_d_e_f_g_h_i_j_k_l_m_n_o_p_q_r_s_t_u_v_w_x_y_z_Should_Return_False()
    {
        var sut = new ValidPalindrome.Solution();
        var actual = sut.IsPalindrome("Abcdefghijklmnopqrstuvwxyz");
        var expected = false;
        Assert.Equal(expected, actual);
    }
}