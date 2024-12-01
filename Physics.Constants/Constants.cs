namespace ktsu.Physics.Constants;

using ktsu.PhysicalQuantity.AngularMomentum;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;

public static class Constants
{
	public static Velocity SpeedOfLight => 299792458.MetersPerSecond();
	public static AngularMomentum PlanckConstant => 6.62607015e-34.KilogramSquareMetersPerSecond();
	public static SignificantNumber GravitationalConstantNewtonMetersSquaredPerKilogramSquared => 6.67430e-11.ToSignificantNumber();
	public static SignificantNumber BoltzmannConstantJoulesPerKelvin => 1.380649e-23.ToSignificantNumber();
	public static SignificantNumber AvogadroConstantReciprocalMoles => 6.02214076e23.ToSignificantNumber();
	public static SignificantNumber MolarGasConstantJoulesPerMoleKelvin => 8.31446261815324.ToSignificantNumber();
}
