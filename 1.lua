function calc_pdk_pm(p, M)
	return 10^(-2.2 * p + 1.6 + math.log(M, 10));
end

function calc_pdk_tboil(t_boil, M)
	return 10^(-0.01 * t_boil + 0.6 + math.log(M, 10));
end

function calc_pdk_n(n, M)
	return 10^(-10 * n + 14.2 + math.log(M, 10));
end

function calc_pdk_sigma(sigma, M)
	return 10^(-0.058 * sigma + 1.12 + math.log(M, 10));
end

function calc_pdk_tmelt(t_melt, M)
	return 10^(-0.012 * t_melt - 1.2 + math.log(M, 10));
end

function error1f(pdk, i1, M)
	return (pdk-i1/pdk)*100;
end

function error2f(pdk, i2, M)
	return (pdk-i2/pdk)*100;
end

function error3f(pdk, i3, M)
	return (pdk-i3/pdk)*100;
end

function error4f(pdk, i4, M)
	return (pdk-i4/pdk)*100;
end

function error5f(pdk, i5, M)
	return (pdk-i5/pdk)*100;
end
