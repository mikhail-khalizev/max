using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_5440-2f2a2fe8")]
        public void Method_1015_5440()
        {
            ii(0x1015_5440, 5); pushd(0xb0);                            /* push 0xb0 */
            ii(0x1015_5445, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0908); /* call 0x10165d52 */
            ii(0x1015_544a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_544b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_544c, 1); pushd(edx);                             /* push edx */
            ii(0x1015_544d, 1); pushd(esi);                             /* push esi */
            ii(0x1015_544e, 1); pushd(edi);                             /* push edi */
            ii(0x1015_544f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_5450, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5452, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x1015_5458, 5); mov(eax, 0x101b_d908);                  /* mov eax, 0x101bd908 */
            ii(0x1015_545d, 5); calld(/* sys */ 0x1016_611f, 0x1_0cbd); /* call 0x1016611f */
            ii(0x1015_5462, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1015_5467, 5); calld(Definitions.my_ctor_0x101b_56fc, -0xc_c7f0); /* call 0x10088c7c */
            ii(0x1015_546c, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1015_546f, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_5472, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1015_5475, 10); mov(memd_a32[ds, 0x101b_d910], 0x1);   /* mov dword [0x101bd910], 0x1 */
            ii(0x1015_547f, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1015_5484, 5); calld(Definitions.my_ctor_0x101b_56fc, -0xc_c80d); /* call 0x10088c7c */
            ii(0x1015_5489, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1015_548c, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1015_548f, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1015_5492, 10); mov(memd_a32[ds, 0x101b_d910], 0x2);   /* mov dword [0x101bd910], 0x2 */
            ii(0x1015_549c, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1015_54a1, 5); calld(Definitions.my_ctor_0x101b_56fc, -0xc_c82a); /* call 0x10088c7c */
            ii(0x1015_54a6, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1015_54a9, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1015_54ac, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1015_54af, 10); mov(memd_a32[ds, 0x101b_d910], 0x3);   /* mov dword [0x101bd910], 0x3 */
            ii(0x1015_54b9, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1015_54be, 5); calld(Definitions.my_ctor_0x101b_56fc, -0xc_c847); /* call 0x10088c7c */
            ii(0x1015_54c3, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1015_54c6, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1015_54c9, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1015_54cc, 10); mov(memd_a32[ds, 0x101b_d910], 0x4);   /* mov dword [0x101bd910], 0x4 */
            ii(0x1015_54d6, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1015_54db, 5); calld(Definitions.my_ctor_0x101b_56fc, -0xc_c864); /* call 0x10088c7c */
            ii(0x1015_54e0, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1015_54e3, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_54e6, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_54e9, 10); mov(memd_a32[ds, 0x101b_d910], 0x5);   /* mov dword [0x101bd910], 0x5 */
            ii(0x1015_54f3, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1015_54f8, 5); calld(Definitions.my_ctor_0x101b_56fc, -0xc_c881); /* call 0x10088c7c */
            ii(0x1015_54fd, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1015_5500, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1015_5503, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_5506, 10); mov(memd_a32[ds, 0x101b_d910], 0x6);   /* mov dword [0x101bd910], 0x6 */
            ii(0x1015_5510, 5); mov(ebx, 0x101b_7510);                  /* mov ebx, 0x101b7510 */
            ii(0x1015_5515, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x1015_551a, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x1015_551f, 5); calld(Definitions.sys_call_ctor_arr_v2, 0x1_0a4c); /* call 0x10165f70 */
            ii(0x1015_5524, 5); mov(eax, 0x101c_9478);                  /* mov eax, 0x101c9478 */
            ii(0x1015_5529, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_ee3e); /* call 0x100766f0 */
            ii(0x1015_552e, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1015_5531, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1015_5534, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_5537, 10); mov(memd_a32[ds, 0x101b_d910], 0x7);   /* mov dword [0x101bd910], 0x7 */
            ii(0x1015_5541, 5); mov(ebx, 0x101b_56fc);                  /* mov ebx, 0x101b56fc */
            ii(0x1015_5546, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1015_554b, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_5550, 5); calld(Definitions.sys_call_ctor_arr_v2, 0x1_0a1b); /* call 0x10165f70 */
            ii(0x1015_5555, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1015_5558, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1015_555b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_555e, 10); mov(memd_a32[ds, 0x101b_d910], 0x8);   /* mov dword [0x101bd910], 0x8 */
            ii(0x1015_5568, 5); mov(ebx, 0x101b_38f8);                  /* mov ebx, 0x101b38f8 */
            ii(0x1015_556d, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1015_5572, 5); mov(eax, 0x101c_94b4);                  /* mov eax, 0x101c94b4 */
            ii(0x1015_5577, 5); calld(Definitions.sys_call_ctor_arr_v2, 0x1_09f4); /* call 0x10165f70 */
            ii(0x1015_557c, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1015_557f, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1015_5582, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_5585, 10); mov(memd_a32[ds, 0x101b_d910], 0x9);   /* mov dword [0x101bd910], 0x9 */
            ii(0x1015_558f, 5); calld(0x1016_4b38, 0xf5a4);             /* call 0x10164b38 */
            ii(0x1015_5594, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5595, 5); mov(eax, StringDefinitions.RefineryForConvertingGoldIntoCreditsCreditsAreRequiredToPurchaseUnitImprovementsToRunAGoldRefineryNeedsASourceOfPowerAndASourceO); /* mov eax, 0x101adfa4 */
            ii(0x1015_559a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_559b, 5); mov(eax, StringDefinitions.GoldRefineries); /* mov eax, 0x101ae0b8 */
            ii(0x1015_55a0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55a1, 5); mov(eax, StringDefinitions.GoldRefinery); /* mov eax, 0x101ae0c8 */
            ii(0x1015_55a6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55a7, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_55ac, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55ad, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_55af, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55b0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_55b5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55b6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_55bb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55bc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_55c1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55c2, 5); mov(eax, 0x347);                        /* mov eax, 0x347 */
            ii(0x1015_55c7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55c8, 5); mov(eax, 0x6f3);                        /* mov eax, 0x6f3 */
            ii(0x1015_55cd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55ce, 5); mov(eax, 0x469);                        /* mov eax, 0x469 */
            ii(0x1015_55d3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55d4, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_55d9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55da, 5); mov(ecx, 0x5e);                         /* mov ecx, 0x5e */
            ii(0x1015_55df, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_55e1, 5); mov(edx, 0x160_4210);                   /* mov edx, 0x1604210 */
            ii(0x1015_55e6, 5); mov(eax, 0x101c_94c8);                  /* mov eax, 0x101c94c8 */
            ii(0x1015_55eb, 5); calld(0x1015_7aaa, 0x24ba);             /* call 0x10157aaa */
            ii(0x1015_55f0, 5); calld(0x1016_4b38, 0xf543);             /* call 0x10164b38 */
            ii(0x1015_55f5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55f6, 5); mov(eax, StringDefinitions.APowerStationConsumesSixFuelEachTurnAndProvidesEnoughPowerForSixFactoriesOrMiningStations); /* mov eax, 0x101ae0d6 */
            ii(0x1015_55fb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_55fc, 5); mov(eax, StringDefinitions.PowerStations); /* mov eax, 0x101ae144 */
            ii(0x1015_5601, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5602, 5); mov(eax, StringDefinitions.PowerStation); /* mov eax, 0x101ae153 */
            ii(0x1015_5607, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5608, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_560d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_560e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5610, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5611, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5616, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5617, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_561c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_561d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5622, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5623, 5); mov(eax, 0x348);                        /* mov eax, 0x348 */
            ii(0x1015_5628, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5629, 5); mov(eax, 0x6f4);                        /* mov eax, 0x6f4 */
            ii(0x1015_562e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_562f, 5); mov(eax, 0x46a);                        /* mov eax, 0x46a */
            ii(0x1015_5634, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5635, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_563a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_563b, 5); mov(ecx, 0x5f);                         /* mov ecx, 0x5f */
            ii(0x1015_5640, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_5645, 5); mov(edx, 0x160_4210);                   /* mov edx, 0x1604210 */
            ii(0x1015_564a, 5); mov(eax, 0x101c_94f3);                  /* mov eax, 0x101c94f3 */
            ii(0x1015_564f, 5); calld(0x1015_7aaa, 0x2456);             /* call 0x10157aaa */
            ii(0x1015_5654, 5); mov(eax, StringDefinitions.APowerGeneratorConsumesTwoFuelEachTurnAndProvidesEnoughPowerForOneMiningStationOrFactoryThePowerGeneratorMustBeConnectedToTheFue); /* mov eax, 0x101ae161 */
            ii(0x1015_5659, 1); pushd(eax);                             /* push eax */
            ii(0x1015_565a, 5); mov(eax, StringDefinitions.APowerGeneratorConsumesTwoFuelEachTurnAndProvidesEnoughPowerForOneMiningStationOrFactoryThePowerGeneratorMustBeConnectedToTheFue2); /* mov eax, 0x101ae249 */
            ii(0x1015_565f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5660, 5); mov(eax, StringDefinitions.PowerGenerators); /* mov eax, 0x101ae331 */
            ii(0x1015_5665, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5666, 5); mov(eax, StringDefinitions.PowerGenerator); /* mov eax, 0x101ae342 */
            ii(0x1015_566b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_566c, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5671, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5672, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5674, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5675, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_567a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_567b, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5680, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5681, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5686, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5687, 5); mov(eax, 0x349);                        /* mov eax, 0x349 */
            ii(0x1015_568c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_568d, 5); mov(eax, 0x6f5);                        /* mov eax, 0x6f5 */
            ii(0x1015_5692, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5693, 5); mov(eax, 0x474);                        /* mov eax, 0x474 */
            ii(0x1015_5698, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5699, 5); mov(eax, 0x2e0);                        /* mov eax, 0x2e0 */
            ii(0x1015_569e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_569f, 5); mov(ecx, 0x60);                         /* mov ecx, 0x60 */
            ii(0x1015_56a4, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1015_56a9, 5); mov(edx, 0x1e0_4200);                   /* mov edx, 0x1e04200 */
            ii(0x1015_56ae, 5); mov(eax, 0x101c_951e);                  /* mov eax, 0x101c951e */
            ii(0x1015_56b3, 5); calld(0x1015_7aaa, 0x23f2);             /* call 0x10157aaa */
            ii(0x1015_56b8, 5); calld(0x1016_4b38, 0xf47b);             /* call 0x10164b38 */
            ii(0x1015_56bd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56be, 5); mov(eax, StringDefinitions.ABarracksHoldsInfiltratorsAndInfantryUnitsInsideTheBarracksIsAMachineShopForRepairingAndImprovingPoweredSuitsAndForManufacturing); /* mov eax, 0x101ae352 */
            ii(0x1015_56c3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56c4, 5); mov(eax, StringDefinitions.Barracks);   /* mov eax, 0x101ae47c */
            ii(0x1015_56c9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56ca, 5); mov(eax, StringDefinitions.Barracks2);  /* mov eax, 0x101ae485 */
            ii(0x1015_56cf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56d0, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_56d5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56d6, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1015_56db, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56dc, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_56e1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56e2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_56e7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56e8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_56ed, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56ee, 5); mov(eax, 0x34a);                        /* mov eax, 0x34a */
            ii(0x1015_56f3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56f4, 5); mov(eax, 0x6f6);                        /* mov eax, 0x6f6 */
            ii(0x1015_56f9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_56fa, 5); mov(eax, 0x46b);                        /* mov eax, 0x46b */
            ii(0x1015_56ff, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5700, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_5705, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5706, 5); mov(ecx, 0x61);                         /* mov ecx, 0x61 */
            ii(0x1015_570b, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1015_5710, 5); mov(edx, 0x140_4210);                   /* mov edx, 0x1404210 */
            ii(0x1015_5715, 5); mov(eax, 0x101c_9549);                  /* mov eax, 0x101c9549 */
            ii(0x1015_571a, 5); calld(0x1015_7aaa, 0x238b);             /* call 0x10157aaa */
            ii(0x1015_571f, 5); calld(0x1016_4b38, 0xf414);             /* call 0x10164b38 */
            ii(0x1015_5724, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5725, 5); mov(eax, StringDefinitions.SpecializedMiningStationForExtractingMagneticMonopoles); /* mov eax, 0x101ae48e */
            ii(0x1015_572a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_572b, 5); mov(eax, StringDefinitions.MonopoleMines); /* mov eax, 0x101ae4cc */
            ii(0x1015_5730, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5731, 5); mov(eax, StringDefinitions.MonopoleMine); /* mov eax, 0x101ae4db */
            ii(0x1015_5736, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5737, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_573c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_573d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_573f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5740, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5745, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5746, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_574b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_574c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5751, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5752, 5); mov(eax, 0x34b);                        /* mov eax, 0x34b */
            ii(0x1015_5757, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5758, 5); mov(eax, 0x6f7);                        /* mov eax, 0x6f7 */
            ii(0x1015_575d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_575e, 5); mov(eax, 0x46c);                        /* mov eax, 0x46c */
            ii(0x1015_5763, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5764, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_5769, 1); pushd(eax);                             /* push eax */
            ii(0x1015_576a, 5); mov(ecx, 0x62);                         /* mov ecx, 0x62 */
            ii(0x1015_576f, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1015_5774, 5); mov(edx, 0x100_0210);                   /* mov edx, 0x1000210 */
            ii(0x1015_5779, 5); mov(eax, 0x101c_9574);                  /* mov eax, 0x101c9574 */
            ii(0x1015_577e, 5); calld(0x1015_7aaa, 0x2327);             /* call 0x10157aaa */
            ii(0x1015_5783, 5); calld(0x1016_4b38, 0xf3b0);             /* call 0x10164b38 */
            ii(0x1015_5788, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5789, 5); mov(eax, StringDefinitions.StationaryLongRangeRadarLongerRangeUnitsLikeMissileLaunchersAndArtilleryCannotFireOnWhatTheyCannotSeeSoItSImportantToHaveAScanne); /* mov eax, 0x101ae4e9 */
            ii(0x1015_578e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_578f, 5); mov(eax, StringDefinitions.Radars);     /* mov eax, 0x101ae59a */
            ii(0x1015_5794, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5795, 5); mov(eax, StringDefinitions.Radar);      /* mov eax, 0x101ae5a1 */
            ii(0x1015_579a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_579b, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_57a0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57a1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_57a3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57a4, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_57a9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57aa, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_57af, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57b0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_57b5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57b6, 5); mov(eax, 0x34c);                        /* mov eax, 0x34c */
            ii(0x1015_57bb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57bc, 5); mov(eax, 0x6f8);                        /* mov eax, 0x6f8 */
            ii(0x1015_57c1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57c2, 5); mov(eax, 0x46d);                        /* mov eax, 0x46d */
            ii(0x1015_57c7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57c8, 5); mov(eax, 0x2e3);                        /* mov eax, 0x2e3 */
            ii(0x1015_57cd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57ce, 5); mov(ecx, 0x63);                         /* mov ecx, 0x63 */
            ii(0x1015_57d3, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1015_57d8, 5); mov(edx, 0x1e0_4204);                   /* mov edx, 0x1e04204 */
            ii(0x1015_57dd, 5); mov(eax, 0x101c_959f);                  /* mov eax, 0x101c959f */
            ii(0x1015_57e2, 5); calld(0x1015_7aaa, 0x22c3);             /* call 0x10157aaa */
            ii(0x1015_57e7, 5); mov(eax, StringDefinitions.StorageUnitsHoldRawMaterialsProducedByAnyMiningStationsThatAreConnectedToThemToFillAnAdjacentEngineerOrConstructorClickTheXferBu); /* mov eax, 0x101ae5a7 */
            ii(0x1015_57ec, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57ed, 5); mov(eax, StringDefinitions.HoldsRawMaterialsMiningStationsProduceRawMaterialsEveryTurnToSaveExtraRawMaterialsAMiningStationMustBeConnectedToAStorageUnit); /* mov eax, 0x101ae677 */
            ii(0x1015_57f2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57f3, 5); mov(eax, StringDefinitions.StorageUnits); /* mov eax, 0x101ae713 */
            ii(0x1015_57f8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57f9, 5); mov(eax, StringDefinitions.StorageUnit); /* mov eax, 0x101ae721 */
            ii(0x1015_57fe, 1); pushd(eax);                             /* push eax */
            ii(0x1015_57ff, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5804, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5805, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_580a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_580b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5810, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5811, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5816, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5817, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_581c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_581d, 5); mov(eax, 0x34d);                        /* mov eax, 0x34d */
            ii(0x1015_5822, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5823, 5); mov(eax, 0x6f9);                        /* mov eax, 0x6f9 */
            ii(0x1015_5828, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5829, 5); mov(eax, 0x471);                        /* mov eax, 0x471 */
            ii(0x1015_582e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_582f, 5); mov(eax, 0x2e0);                        /* mov eax, 0x2e0 */
            ii(0x1015_5834, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5835, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1015_583a, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1015_583f, 5); mov(edx, 0x1c0_4200);                   /* mov edx, 0x1c04200 */
            ii(0x1015_5844, 5); mov(eax, 0x101c_95ca);                  /* mov eax, 0x101c95ca */
            ii(0x1015_5849, 5); calld(0x1015_7aaa, 0x225c);             /* call 0x10157aaa */
            ii(0x1015_584e, 5); mov(eax, StringDefinitions.HoldsFuelReservesMiningStationsProduceFuelEveryTurnToSaveExtraFuelAMiningStationMustBeConnectedToAFuelTank); /* mov eax, 0x101ae72e */
            ii(0x1015_5853, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5854, 5); mov(eax, StringDefinitions.HoldsFuelReservesMiningStationsProduceFuelEveryTurnToSaveExtraFuelAMiningStationMustBeConnectedToAFuelTank2); /* mov eax, 0x101ae7b5 */
            ii(0x1015_5859, 1); pushd(eax);                             /* push eax */
            ii(0x1015_585a, 5); mov(eax, StringDefinitions.FuelTanks);  /* mov eax, 0x101ae83c */
            ii(0x1015_585f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5860, 5); mov(eax, StringDefinitions.FuelTank);   /* mov eax, 0x101ae847 */
            ii(0x1015_5865, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5866, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_586b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_586c, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_5871, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5872, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5877, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5878, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_587d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_587e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5883, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5884, 5); mov(eax, 0x34e);                        /* mov eax, 0x34e */
            ii(0x1015_5889, 1); pushd(eax);                             /* push eax */
            ii(0x1015_588a, 5); mov(eax, 0x6fa);                        /* mov eax, 0x6fa */
            ii(0x1015_588f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5890, 5); mov(eax, 0x472);                        /* mov eax, 0x472 */
            ii(0x1015_5895, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5896, 5); mov(eax, 0x2e0);                        /* mov eax, 0x2e0 */
            ii(0x1015_589b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_589c, 5); mov(ecx, 0x65);                         /* mov ecx, 0x65 */
            ii(0x1015_58a1, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x1015_58a6, 5); mov(edx, 0x1c0_4200);                   /* mov edx, 0x1c04200 */
            ii(0x1015_58ab, 5); mov(eax, 0x101c_95f5);                  /* mov eax, 0x101c95f5 */
            ii(0x1015_58b0, 5); calld(0x1015_7aaa, 0x21f5);             /* call 0x10157aaa */
            ii(0x1015_58b5, 5); mov(eax, StringDefinitions.HoldsUnrefinedGoldOreMiningStationsProduceGoldEveryTurnIfTheyHaveGoldOreUnderneathThemToStoreTheOreAMiningStationMustBeConnected); /* mov eax, 0x101ae851 */
            ii(0x1015_58ba, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58bb, 5); mov(eax, StringDefinitions.HoldsUnrefinedGoldOreMiningStationsProduceGoldEveryTurnIfTheyHaveGoldOreUnderneathThemToStoreTheOreAMiningStationMustBeConnected2); /* mov eax, 0x101ae903 */
            ii(0x1015_58c0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58c1, 5); mov(eax, StringDefinitions.GoldVaults); /* mov eax, 0x101ae9b5 */
            ii(0x1015_58c6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58c7, 5); mov(eax, StringDefinitions.GoldVault);  /* mov eax, 0x101ae9c1 */
            ii(0x1015_58cc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58cd, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_58d2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58d3, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1015_58d8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58d9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_58de, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58df, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_58e4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58e5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_58ea, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58eb, 5); mov(eax, 0x34f);                        /* mov eax, 0x34f */
            ii(0x1015_58f0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58f1, 5); mov(eax, 0x6fb);                        /* mov eax, 0x6fb */
            ii(0x1015_58f6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58f7, 5); mov(eax, 0x473);                        /* mov eax, 0x473 */
            ii(0x1015_58fc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_58fd, 5); mov(eax, 0x2e0);                        /* mov eax, 0x2e0 */
            ii(0x1015_5902, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5903, 5); mov(ecx, 0x66);                         /* mov ecx, 0x66 */
            ii(0x1015_5908, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1015_590d, 5); mov(edx, 0x1c0_4200);                   /* mov edx, 0x1c04200 */
            ii(0x1015_5912, 5); mov(eax, 0x101c_9620);                  /* mov eax, 0x101c9620 */
            ii(0x1015_5917, 5); calld(0x1015_7aaa, 0x218e);             /* call 0x10157aaa */
            ii(0x1015_591c, 5); mov(eax, StringDefinitions.DepotsPerformRepairsAndSupplyAmmunitionToDriveAUnitIntoTheDepotClickLoadAndThenClickOnTheUnitToLookInsideTheDepotClickActivate); /* mov eax, 0x101ae9cc */
            ii(0x1015_5921, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5922, 5); mov(eax, StringDefinitions.ADepotCanRepairDamageManufactureAmmunitionAndRefitGroundUnitsWithTheNewestTechnologyAllOfTheseOperationsRequireRawMaterialsSoDep); /* mov eax, 0x101aea70 */
            ii(0x1015_5927, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5928, 5); mov(eax, StringDefinitions.Depots);     /* mov eax, 0x101aeb39 */
            ii(0x1015_592d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_592e, 5); mov(eax, StringDefinitions.Depot);      /* mov eax, 0x101aeb40 */
            ii(0x1015_5933, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5934, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5939, 1); pushd(eax);                             /* push eax */
            ii(0x1015_593a, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1015_593f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5940, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5945, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5946, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_594b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_594c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5951, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5952, 5); mov(eax, 0x350);                        /* mov eax, 0x350 */
            ii(0x1015_5957, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5958, 5); mov(eax, 0x6fc);                        /* mov eax, 0x6fc */
            ii(0x1015_595d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_595e, 5); mov(eax, 0x46e);                        /* mov eax, 0x46e */
            ii(0x1015_5963, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5964, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_5969, 1); pushd(eax);                             /* push eax */
            ii(0x1015_596a, 5); mov(ecx, 0x67);                         /* mov ecx, 0x67 */
            ii(0x1015_596f, 5); mov(ebx, 0x9);                          /* mov ebx, 0x9 */
            ii(0x1015_5974, 5); mov(edx, 0x140_4210);                   /* mov edx, 0x1404210 */
            ii(0x1015_5979, 5); mov(eax, 0x101c_964b);                  /* mov eax, 0x101c964b */
            ii(0x1015_597e, 5); calld(0x1015_7aaa, 0x2127);             /* call 0x10157aaa */
            ii(0x1015_5983, 5); calld(0x1016_4b38, 0xf1b0);             /* call 0x10164b38 */
            ii(0x1015_5988, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5989, 5); mov(eax, StringDefinitions.AHangarCanRepairDamageManufactureAmmunitionAndRefitPlanesWithTheNewestTechnologyAllOfTheseOperationsRequireRawMaterialsSoHangars); /* mov eax, 0x101aeb46 */
            ii(0x1015_598e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_598f, 5); mov(eax, StringDefinitions.Hangars);    /* mov eax, 0x101aec0b */
            ii(0x1015_5994, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5995, 5); mov(eax, StringDefinitions.Hangar);     /* mov eax, 0x101aec13 */
            ii(0x1015_599a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_599b, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_59a0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59a1, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1015_59a6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59a7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_59ac, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59ad, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_59b2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59b3, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_59b8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59b9, 5); mov(eax, 0x351);                        /* mov eax, 0x351 */
            ii(0x1015_59be, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59bf, 5); mov(eax, 0x6fd);                        /* mov eax, 0x6fd */
            ii(0x1015_59c4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59c5, 5); mov(eax, 0x46f);                        /* mov eax, 0x46f */
            ii(0x1015_59ca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59cb, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_59d0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59d1, 5); mov(ecx, 0x68);                         /* mov ecx, 0x68 */
            ii(0x1015_59d6, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1015_59db, 5); mov(edx, 0x140_4210);                   /* mov edx, 0x1404210 */
            ii(0x1015_59e0, 5); mov(eax, 0x101c_9676);                  /* mov eax, 0x101c9676 */
            ii(0x1015_59e5, 5); calld(0x1015_7aaa, 0x20c0);             /* call 0x10157aaa */
            ii(0x1015_59ea, 5); calld(0x1016_4b38, 0xf149);             /* call 0x10164b38 */
            ii(0x1015_59ef, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59f0, 5); mov(eax, StringDefinitions.ADockCanRepairDamageManufactureAmmunitionAndRefitShipsWithTheNewestTechnologyAllOfTheseOperationsRequireRawMaterialsSoDocksShoul); /* mov eax, 0x101aec1a */
            ii(0x1015_59f5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59f6, 5); mov(eax, StringDefinitions.Docks);      /* mov eax, 0x101aecda */
            ii(0x1015_59fb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_59fc, 5); mov(eax, StringDefinitions.Dock);       /* mov eax, 0x101aece0 */
            ii(0x1015_5a01, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a02, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5a07, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a08, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1015_5a0d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a0e, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_5a13, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a14, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5a19, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a1a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5a1f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a20, 5); mov(eax, 0x352);                        /* mov eax, 0x352 */
            ii(0x1015_5a25, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a26, 5); mov(eax, 0x6fe);                        /* mov eax, 0x6fe */
            ii(0x1015_5a2b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a2c, 5); mov(eax, 0x470);                        /* mov eax, 0x470 */
            ii(0x1015_5a31, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a32, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_5a37, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a38, 5); mov(ecx, 0x69);                         /* mov ecx, 0x69 */
            ii(0x1015_5a3d, 5); mov(ebx, 0xb);                          /* mov ebx, 0xb */
            ii(0x1015_5a42, 5); mov(edx, 0x40_4210);                    /* mov edx, 0x404210 */
            ii(0x1015_5a47, 5); mov(eax, 0x101c_96a1);                  /* mov eax, 0x101c96a1 */
            ii(0x1015_5a4c, 5); calld(0x1015_7aaa, 0x2059);             /* call 0x10157aaa */
            ii(0x1015_5a51, 5); mov(eax, StringDefinitions.BuildingsMustBeConnectedToSharePowerFuelRawMaterialsAndGoldYouCanConnectBuildingsByPlacingThemNextToEachOtherOrByBuildingConnect); /* mov eax, 0x101aece5 */
            ii(0x1015_5a56, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a57, 5); mov(eax, StringDefinitions.BuildingsMustBeConnectedToSharePowerFuelRawMaterialsAndGoldYouCanConnectBuildingsByPlacingThemNextToEachOtherOrByBuildingConnect2); /* mov eax, 0x101aeda9 */
            ii(0x1015_5a5c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a5d, 5); mov(eax, StringDefinitions.Connectors); /* mov eax, 0x101aee6d */
            ii(0x1015_5a62, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a63, 5); mov(eax, StringDefinitions.Connector);  /* mov eax, 0x101aee78 */
            ii(0x1015_5a68, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a69, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5a6e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a6f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5a71, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a72, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_5a77, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a78, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5a7d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a7e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5a83, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a84, 5); mov(eax, 0x353);                        /* mov eax, 0x353 */
            ii(0x1015_5a89, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a8a, 5); mov(eax, 0x6ff);                        /* mov eax, 0x6ff */
            ii(0x1015_5a8f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a90, 5); mov(eax, 0x475);                        /* mov eax, 0x475 */
            ii(0x1015_5a95, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a96, 5); mov(eax, 0x2e0);                        /* mov eax, 0x2e0 */
            ii(0x1015_5a9b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5a9c, 5); mov(ecx, 0x6a);                         /* mov ecx, 0x6a */
            ii(0x1015_5aa1, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1015_5aa6, 5); mov(edx, 0x40_4208);                    /* mov edx, 0x404208 */
            ii(0x1015_5aab, 5); mov(eax, 0x101c_96cc);                  /* mov eax, 0x101c96cc */
            ii(0x1015_5ab0, 5); calld(0x1015_7aaa, 0x1ff5);             /* call 0x10157aaa */
            ii(0x1015_5ab5, 5); calld(0x1016_4b38, 0xf07e);             /* call 0x10164b38 */
            ii(0x1015_5aba, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5abb, 5); mov(eax, StringDefinitions.Empty14);    /* mov eax, 0x101aee82 */
            ii(0x1015_5ac0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ac1, 5); mov(eax, StringDefinitions.Empty15);    /* mov eax, 0x101aee83 */
            ii(0x1015_5ac6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ac7, 5); mov(eax, StringDefinitions.LargeRubble1); /* mov eax, 0x101aee84 */
            ii(0x1015_5acc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5acd, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5ad2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ad3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5ad5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ad6, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5adb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5adc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ae1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ae2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ae7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ae8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5aed, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5aee, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5af3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5af4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5af9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5afa, 5); mov(eax, 0x2ee);                        /* mov eax, 0x2ee */
            ii(0x1015_5aff, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b00, 5); mov(ecx, 0x6b);                         /* mov ecx, 0x6b */
            ii(0x1015_5b05, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1015_5b0a, 5); mov(edx, 0x211);                        /* mov edx, 0x211 */
            ii(0x1015_5b0f, 5); mov(eax, 0x101c_96f7);                  /* mov eax, 0x101c96f7 */
            ii(0x1015_5b14, 5); calld(0x1015_7aaa, 0x1f91);             /* call 0x10157aaa */
            ii(0x1015_5b19, 5); calld(0x1016_4b38, 0xf01a);             /* call 0x10164b38 */
            ii(0x1015_5b1e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b1f, 5); mov(eax, StringDefinitions.Empty16);    /* mov eax, 0x101aee93 */
            ii(0x1015_5b24, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b25, 5); mov(eax, StringDefinitions.Empty17);    /* mov eax, 0x101aee94 */
            ii(0x1015_5b2a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b2b, 5); mov(eax, StringDefinitions.SmallRubble1); /* mov eax, 0x101aee95 */
            ii(0x1015_5b30, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b31, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5b36, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b37, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5b39, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b3a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5b3f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b40, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5b45, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b46, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5b4b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b4c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5b51, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b52, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5b57, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b58, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5b5d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b5e, 5); mov(eax, 0x2ef);                        /* mov eax, 0x2ef */
            ii(0x1015_5b63, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b64, 5); mov(ecx, 0x6c);                         /* mov ecx, 0x6c */
            ii(0x1015_5b69, 5); mov(ebx, 0xe);                          /* mov ebx, 0xe */
            ii(0x1015_5b6e, 5); mov(edx, 0x201);                        /* mov edx, 0x201 */
            ii(0x1015_5b73, 5); mov(eax, 0x101c_9722);                  /* mov eax, 0x101c9722 */
            ii(0x1015_5b78, 5); calld(0x1015_7aaa, 0x1f2d);             /* call 0x10157aaa */
            ii(0x1015_5b7d, 5); calld(0x1016_4b38, 0xefb6);             /* call 0x10164b38 */
            ii(0x1015_5b82, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b83, 5); mov(eax, StringDefinitions.Empty18);    /* mov eax, 0x101aeea3 */
            ii(0x1015_5b88, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b89, 5); mov(eax, StringDefinitions.Empty19);    /* mov eax, 0x101aeea4 */
            ii(0x1015_5b8e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b8f, 5); mov(eax, StringDefinitions.LargeTape);  /* mov eax, 0x101aeea5 */
            ii(0x1015_5b94, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b95, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5b9a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b9b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5b9d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5b9e, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_5ba3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ba4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ba9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5baa, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5baf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bb0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5bb5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bb6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5bbb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bbc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5bc1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bc2, 5); mov(eax, 0x2ee);                        /* mov eax, 0x2ee */
            ii(0x1015_5bc7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bc8, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_5bcd, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1015_5bd2, 5); mov(edx, 0x40_0211);                    /* mov edx, 0x400211 */
            ii(0x1015_5bd7, 5); mov(eax, 0x101c_974d);                  /* mov eax, 0x101c974d */
            ii(0x1015_5bdc, 5); calld(0x1015_7aaa, 0x1ec9);             /* call 0x10157aaa */
            ii(0x1015_5be1, 5); calld(0x1016_4b38, 0xef52);             /* call 0x10164b38 */
            ii(0x1015_5be6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5be7, 5); mov(eax, StringDefinitions.Empty20);    /* mov eax, 0x101aeeb0 */
            ii(0x1015_5bec, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bed, 5); mov(eax, StringDefinitions.Empty21);    /* mov eax, 0x101aeeb1 */
            ii(0x1015_5bf2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bf3, 5); mov(eax, StringDefinitions.SmallTape);  /* mov eax, 0x101aeeb2 */
            ii(0x1015_5bf8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bf9, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5bfe, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5bff, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5c01, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c02, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_5c07, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c08, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c0d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c0e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c13, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c14, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c19, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c1a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c1f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c20, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c25, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c26, 5); mov(eax, 0x2ee);                        /* mov eax, 0x2ee */
            ii(0x1015_5c2b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c2c, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_5c31, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1015_5c36, 5); mov(edx, 0x40_0201);                    /* mov edx, 0x400201 */
            ii(0x1015_5c3b, 5); mov(eax, 0x101c_9778);                  /* mov eax, 0x101c9778 */
            ii(0x1015_5c40, 5); calld(0x1015_7aaa, 0x1e65);             /* call 0x10157aaa */
            ii(0x1015_5c45, 5); calld(0x1016_4b38, 0xeeee);             /* call 0x10164b38 */
            ii(0x1015_5c4a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c4b, 5); mov(eax, StringDefinitions.Empty22);    /* mov eax, 0x101aeebd */
            ii(0x1015_5c50, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c51, 5); mov(eax, StringDefinitions.Empty23);    /* mov eax, 0x101aeebe */
            ii(0x1015_5c56, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c57, 5); mov(eax, StringDefinitions.LargeSlab);  /* mov eax, 0x101aeebf */
            ii(0x1015_5c5c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c5d, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5c62, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c63, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5c65, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c66, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5c6b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c6c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c71, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c72, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c77, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c78, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c7d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c7e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c83, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c84, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5c89, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c8a, 5); mov(eax, 0x2f0);                        /* mov eax, 0x2f0 */
            ii(0x1015_5c8f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5c90, 5); mov(ecx, 0x6d);                         /* mov ecx, 0x6d */
            ii(0x1015_5c95, 5); mov(ebx, 0x11);                         /* mov ebx, 0x11 */
            ii(0x1015_5c9a, 5); mov(edx, 0x211);                        /* mov edx, 0x211 */
            ii(0x1015_5c9f, 5); mov(eax, 0x101c_97a3);                  /* mov eax, 0x101c97a3 */
            ii(0x1015_5ca4, 5); calld(0x1015_7aaa, 0x1e01);             /* call 0x10157aaa */
            ii(0x1015_5ca9, 5); calld(0x1016_4b38, 0xee8a);             /* call 0x10164b38 */
            ii(0x1015_5cae, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5caf, 5); mov(eax, StringDefinitions.Empty24);    /* mov eax, 0x101aeeca */
            ii(0x1015_5cb4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cb5, 5); mov(eax, StringDefinitions.Empty25);    /* mov eax, 0x101aeecb */
            ii(0x1015_5cba, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cbb, 5); mov(eax, StringDefinitions.SmallSlab);  /* mov eax, 0x101aeecc */
            ii(0x1015_5cc0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cc1, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5cc6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cc7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5cc9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cca, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5ccf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cd0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5cd5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cd6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5cdb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cdc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ce1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ce2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ce7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ce8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ced, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cee, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_5cf3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5cf4, 5); mov(ecx, 0x6f);                         /* mov ecx, 0x6f */
            ii(0x1015_5cf9, 5); mov(ebx, 0x12);                         /* mov ebx, 0x12 */
            ii(0x1015_5cfe, 5); mov(edx, 0x201);                        /* mov edx, 0x201 */
            ii(0x1015_5d03, 5); mov(eax, 0x101c_97ce);                  /* mov eax, 0x101c97ce */
            ii(0x1015_5d08, 5); calld(0x1015_7aaa, 0x1d9d);             /* call 0x10157aaa */
            ii(0x1015_5d0d, 5); calld(0x1016_4b38, 0xee26);             /* call 0x10164b38 */
            ii(0x1015_5d12, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d13, 5); mov(eax, StringDefinitions.Empty26);    /* mov eax, 0x101aeed7 */
            ii(0x1015_5d18, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d19, 5); mov(eax, StringDefinitions.Empty27);    /* mov eax, 0x101aeed8 */
            ii(0x1015_5d1e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d1f, 5); mov(eax, StringDefinitions.LargeCones); /* mov eax, 0x101aeed9 */
            ii(0x1015_5d24, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d25, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5d2a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d2b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5d2d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d2e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5d33, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d34, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5d39, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d3a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5d3f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d40, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5d45, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d46, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5d4b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d4c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5d51, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d52, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_5d57, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d58, 5); mov(ecx, 0x6e);                         /* mov ecx, 0x6e */
            ii(0x1015_5d5d, 5); mov(ebx, 0x13);                         /* mov ebx, 0x13 */
            ii(0x1015_5d62, 5); mov(edx, 0x211);                        /* mov edx, 0x211 */
            ii(0x1015_5d67, 5); mov(eax, 0x101c_97f9);                  /* mov eax, 0x101c97f9 */
            ii(0x1015_5d6c, 5); calld(0x1015_7aaa, 0x1d39);             /* call 0x10157aaa */
            ii(0x1015_5d71, 5); calld(0x1016_4b38, 0xedc2);             /* call 0x10164b38 */
            ii(0x1015_5d76, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d77, 5); mov(eax, StringDefinitions.Empty28);    /* mov eax, 0x101aeee5 */
            ii(0x1015_5d7c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d7d, 5); mov(eax, StringDefinitions.Empty29);    /* mov eax, 0x101aeee6 */
            ii(0x1015_5d82, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d83, 5); mov(eax, StringDefinitions.SmallCones); /* mov eax, 0x101aeee7 */
            ii(0x1015_5d88, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d89, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5d8e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d8f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5d91, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d92, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5d97, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d98, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5d9d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5d9e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5da3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5da4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5da9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5daa, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5daf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5db0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5db5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5db6, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_5dbb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5dbc, 5); mov(ecx, 0x70);                         /* mov ecx, 0x70 */
            ii(0x1015_5dc1, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x1015_5dc6, 5); mov(edx, 0x201);                        /* mov edx, 0x201 */
            ii(0x1015_5dcb, 5); mov(eax, 0x101c_9824);                  /* mov eax, 0x101c9824 */
            ii(0x1015_5dd0, 5); calld(0x1015_7aaa, 0x1cd5);             /* call 0x10157aaa */
            ii(0x1015_5dd5, 5); calld(0x1016_4b38, 0xed5e);             /* call 0x10164b38 */
            ii(0x1015_5dda, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ddb, 5); mov(eax, StringDefinitions.UnitsMoveTwiceAsFastOverRoadSquares); /* mov eax, 0x101aeef3 */
            ii(0x1015_5de0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5de1, 5); mov(eax, StringDefinitions.Roads);      /* mov eax, 0x101aef1f */
            ii(0x1015_5de6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5de7, 5); mov(eax, StringDefinitions.Road);       /* mov eax, 0x101aef25 */
            ii(0x1015_5dec, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ded, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5df2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5df3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5df5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5df6, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5dfb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5dfc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5e01, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e02, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5e07, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e08, 5); mov(eax, 0x354);                        /* mov eax, 0x354 */
            ii(0x1015_5e0d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e0e, 5); mov(eax, 0x700);                        /* mov eax, 0x700 */
            ii(0x1015_5e13, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e14, 5); mov(eax, 0x476);                        /* mov eax, 0x476 */
            ii(0x1015_5e19, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e1a, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_5e1f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e20, 5); mov(ecx, 0x71);                         /* mov ecx, 0x71 */
            ii(0x1015_5e25, 5); mov(ebx, 0x15);                         /* mov ebx, 0x15 */
            ii(0x1015_5e2a, 5); mov(edx, 0x40_0201);                    /* mov edx, 0x400201 */
            ii(0x1015_5e2f, 5); mov(eax, 0x101c_984f);                  /* mov eax, 0x101c984f */
            ii(0x1015_5e34, 5); calld(0x1015_7aaa, 0x1c71);             /* call 0x10157aaa */
            ii(0x1015_5e39, 5); calld(0x1016_4b38, 0xecfa);             /* call 0x10164b38 */
            ii(0x1015_5e3e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e3f, 5); mov(eax, StringDefinitions.LandingFacilityForPlanesDoesNotRepairResupplyOrRefuelPlanesToResupplyAPlaneOnALandingPadUseANearbyTruckOrStorageUnit); /* mov eax, 0x101aef2a */
            ii(0x1015_5e44, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e45, 5); mov(eax, StringDefinitions.LandingPads); /* mov eax, 0x101aefc0 */
            ii(0x1015_5e4a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e4b, 5); mov(eax, StringDefinitions.LandingPad); /* mov eax, 0x101aefcd */
            ii(0x1015_5e50, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e51, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5e56, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e57, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1015_5e5c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e5d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5e62, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e63, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5e68, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e69, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5e6e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e6f, 5); mov(eax, 0x355);                        /* mov eax, 0x355 */
            ii(0x1015_5e74, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e75, 5); mov(eax, 0x701);                        /* mov eax, 0x701 */
            ii(0x1015_5e7a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e7b, 5); mov(eax, 0x477);                        /* mov eax, 0x477 */
            ii(0x1015_5e80, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e81, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_5e86, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5e87, 5); mov(ecx, 0x72);                         /* mov ecx, 0x72 */
            ii(0x1015_5e8c, 5); mov(ebx, 0x16);                         /* mov ebx, 0x16 */
            ii(0x1015_5e91, 5); mov(edx, 0x40_4200);                    /* mov edx, 0x404200 */
            ii(0x1015_5e96, 5); mov(eax, 0x101c_987a);                  /* mov eax, 0x101c987a */
            ii(0x1015_5e9b, 5); calld(0x1015_7aaa, 0x1c0a);             /* call 0x10157aaa */
            ii(0x1015_5ea0, 5); calld(0x1016_4b38, 0xec93);             /* call 0x10164b38 */
            ii(0x1015_5ea5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ea6, 5); mov(eax, StringDefinitions.ShipyardsManufactureShipsSuchAsSubmarinesSeaTransportsAndMissileCruisersAShipyardRequiresThreeRawMaterialsATurnToOperateAndPower); /* mov eax, 0x101aefd9 */
            ii(0x1015_5eab, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5eac, 5); mov(eax, StringDefinitions.Shipyards);  /* mov eax, 0x101af09f */
            ii(0x1015_5eb1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5eb2, 5); mov(eax, StringDefinitions.Shipyard);   /* mov eax, 0x101af0a9 */
            ii(0x1015_5eb7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5eb8, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5ebd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ebe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5ec0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ec1, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_5ec6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ec7, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ecc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ecd, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ed2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ed3, 5); mov(eax, 0x356);                        /* mov eax, 0x356 */
            ii(0x1015_5ed8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ed9, 5); mov(eax, 0x702);                        /* mov eax, 0x702 */
            ii(0x1015_5ede, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5edf, 5); mov(eax, 0x478);                        /* mov eax, 0x478 */
            ii(0x1015_5ee4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ee5, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_5eea, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5eeb, 5); mov(ecx, 0x73);                         /* mov ecx, 0x73 */
            ii(0x1015_5ef0, 5); mov(ebx, 0x17);                         /* mov ebx, 0x17 */
            ii(0x1015_5ef5, 5); mov(edx, 0x68_4210);                    /* mov edx, 0x684210 */
            ii(0x1015_5efa, 5); mov(eax, 0x101c_98a5);                  /* mov eax, 0x101c98a5 */
            ii(0x1015_5eff, 5); calld(0x1015_7aaa, 0x1ba6);             /* call 0x10157aaa */
            ii(0x1015_5f04, 5); mov(eax, StringDefinitions.ClickOnTheLightVehiclePlantToShowTheBuildButtonFactoriesNeedToBeConnectedToPowerAndASourceOfRawMaterialsUsuallyAMiningStationToO); /* mov eax, 0x101af0b2 */
            ii(0x1015_5f09, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f0a, 5); mov(eax, StringDefinitions.BuildsLightVehiclesEngineersTrucksMobileRepairUnitsScoutsAndMobileAntiAircraftUnitsALightVehiclePlantRequiresThreeRawMaterialsAT); /* mov eax, 0x101af15b */
            ii(0x1015_5f0f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f10, 5); mov(eax, StringDefinitions.LightVehiclePlants); /* mov eax, 0x101af23c */
            ii(0x1015_5f15, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f16, 5); mov(eax, StringDefinitions.LightVehiclePlant); /* mov eax, 0x101af251 */
            ii(0x1015_5f1b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f1c, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5f21, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f22, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5f24, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f25, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5f2a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f2b, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5f30, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f31, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5f36, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f37, 5); mov(eax, 0x357);                        /* mov eax, 0x357 */
            ii(0x1015_5f3c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f3d, 5); mov(eax, 0x703);                        /* mov eax, 0x703 */
            ii(0x1015_5f42, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f43, 5); mov(eax, 0x479);                        /* mov eax, 0x479 */
            ii(0x1015_5f48, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f49, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_5f4e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f4f, 5); mov(ecx, 0x74);                         /* mov ecx, 0x74 */
            ii(0x1015_5f54, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1015_5f59, 5); mov(edx, 0x168_4210);                   /* mov edx, 0x1684210 */
            ii(0x1015_5f5e, 5); mov(eax, 0x101c_98d0);                  /* mov eax, 0x101c98d0 */
            ii(0x1015_5f63, 5); calld(0x1015_7aaa, 0x1b42);             /* call 0x10157aaa */
            ii(0x1015_5f68, 5); mov(eax, StringDefinitions.ClickOnTheHeavyVehiclePlantToShowTheBuildButtonFactoriesNeedToBeConnectedToPowerAndASourceOfRawMaterialsUsuallyAMiningStationToO); /* mov eax, 0x101af265 */
            ii(0x1015_5f6d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f6e, 5); mov(eax, StringDefinitions.BuildsConstructorsMobileScannersAndTheHeavyFightingUnitsTanksAssaultGunsRocketLaunchersAndMissileCrawlersAHeavyFactoryNeedsThree); /* mov eax, 0x101af30e */
            ii(0x1015_5f73, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f74, 5); mov(eax, StringDefinitions.HeavyVehiclePlants); /* mov eax, 0x101af400 */
            ii(0x1015_5f79, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f7a, 5); mov(eax, StringDefinitions.HeavyVehiclePlant); /* mov eax, 0x101af415 */
            ii(0x1015_5f7f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f80, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5f85, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f86, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5f88, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f89, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5f8e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f8f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5f94, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f95, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5f9a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5f9b, 5); mov(eax, 0x358);                        /* mov eax, 0x358 */
            ii(0x1015_5fa0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fa1, 5); mov(eax, 0x704);                        /* mov eax, 0x704 */
            ii(0x1015_5fa6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fa7, 5); mov(eax, 0x47a);                        /* mov eax, 0x47a */
            ii(0x1015_5fac, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fad, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_5fb2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fb3, 5); mov(ecx, 0x75);                         /* mov ecx, 0x75 */
            ii(0x1015_5fb8, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1015_5fbd, 5); mov(edx, 0x168_4210);                   /* mov edx, 0x1684210 */
            ii(0x1015_5fc2, 5); mov(eax, 0x101c_98fb);                  /* mov eax, 0x101c98fb */
            ii(0x1015_5fc7, 5); calld(0x1015_7aaa, 0x1ade);             /* call 0x10157aaa */
            ii(0x1015_5fcc, 5); calld(0x1016_4b38, 0xeb67);             /* call 0x10164b38 */
            ii(0x1015_5fd1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fd2, 5); mov(eax, StringDefinitions.Empty30);    /* mov eax, 0x101af429 */
            ii(0x1015_5fd7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fd8, 5); mov(eax, StringDefinitions.Empty31);    /* mov eax, 0x101af42a */
            ii(0x1015_5fdd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fde, 5); mov(eax, StringDefinitions.Empty32);    /* mov eax, 0x101af42b */
            ii(0x1015_5fe3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fe4, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_5fe9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_5fec, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fed, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_5ff2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ff3, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ff8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5ff9, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_5ffe, 1); pushd(eax);                             /* push eax */
            ii(0x1015_5fff, 5); mov(eax, 0x359);                        /* mov eax, 0x359 */
            ii(0x1015_6004, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6005, 5); mov(eax, 0x705);                        /* mov eax, 0x705 */
            ii(0x1015_600a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_600b, 5); mov(eax, 0x47b);                        /* mov eax, 0x47b */
            ii(0x1015_6010, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6011, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_6016, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6017, 5); mov(ecx, 0x76);                         /* mov ecx, 0x76 */
            ii(0x1015_601c, 5); mov(ebx, 0x1a);                         /* mov ebx, 0x1a */
            ii(0x1015_6021, 5); mov(edx, 0x100_0210);                   /* mov edx, 0x1000210 */
            ii(0x1015_6026, 5); mov(eax, 0x101c_9926);                  /* mov eax, 0x101c9926 */
            ii(0x1015_602b, 5); calld(0x1015_7aaa, 0x1a7a);             /* call 0x10157aaa */
            ii(0x1015_6030, 5); calld(0x1016_4b38, 0xeb03);             /* call 0x10164b38 */
            ii(0x1015_6035, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6036, 5); mov(eax, StringDefinitions.BuildsFightersGroundAttackPlanesAndAirTransportsAHeavyFactoryNeedsThreeRawMaterialsATurnToOperateAndPowerFromAPowerGeneratorOrPo); /* mov eax, 0x101af42c */
            ii(0x1015_603b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_603c, 5); mov(eax, StringDefinitions.AirUnitsPlants); /* mov eax, 0x101af4d8 */
            ii(0x1015_6041, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6042, 5); mov(eax, StringDefinitions.AirUnitsPlant); /* mov eax, 0x101af4e9 */
            ii(0x1015_6047, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6048, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_604d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_604e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6050, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6051, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6056, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6057, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_605c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_605d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6062, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6063, 5); mov(eax, 0x35a);                        /* mov eax, 0x35a */
            ii(0x1015_6068, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6069, 5); mov(eax, 0x706);                        /* mov eax, 0x706 */
            ii(0x1015_606e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_606f, 5); mov(eax, 0x47c);                        /* mov eax, 0x47c */
            ii(0x1015_6074, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6075, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_607a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_607b, 5); mov(ecx, 0x77);                         /* mov ecx, 0x77 */
            ii(0x1015_6080, 5); mov(ebx, 0x1b);                         /* mov ebx, 0x1b */
            ii(0x1015_6085, 5); mov(edx, 0x168_4210);                   /* mov edx, 0x1684210 */
            ii(0x1015_608a, 5); mov(eax, 0x101c_9951);                  /* mov eax, 0x101c9951 */
            ii(0x1015_608f, 5); calld(0x1015_7aaa, 0x1a16);             /* call 0x10157aaa */
            ii(0x1015_6094, 5); calld(0x1016_4b38, 0xea9f);             /* call 0x10164b38 */
            ii(0x1015_6099, 1); pushd(eax);                             /* push eax */
            ii(0x1015_609a, 5); mov(eax, StringDefinitions.HabitatsHouseColonistsEachHabitatHousesEnoughColonistsToOperateThreeResearchCentersTrainingHallsOrEcoSpheresTheColonistBuildings); /* mov eax, 0x101af4f9 */
            ii(0x1015_609f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60a0, 5); mov(eax, StringDefinitions.Habitats);   /* mov eax, 0x101af5ce */
            ii(0x1015_60a5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60a6, 5); mov(eax, StringDefinitions.Habitat);    /* mov eax, 0x101af5d7 */
            ii(0x1015_60ab, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60ac, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_60b1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60b2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_60b4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60b5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_60ba, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60bb, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_60c0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60c1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_60c6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60c7, 5); mov(eax, 0x35b);                        /* mov eax, 0x35b */
            ii(0x1015_60cc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60cd, 5); mov(eax, 0x707);                        /* mov eax, 0x707 */
            ii(0x1015_60d2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60d3, 5); mov(eax, 0x47d);                        /* mov eax, 0x47d */
            ii(0x1015_60d8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60d9, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_60de, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60df, 5); mov(ecx, 0x78);                         /* mov ecx, 0x78 */
            ii(0x1015_60e4, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1015_60e9, 5); mov(edx, 0x140_4210);                   /* mov edx, 0x1404210 */
            ii(0x1015_60ee, 5); mov(eax, 0x101c_997c);                  /* mov eax, 0x101c997c */
            ii(0x1015_60f3, 5); calld(0x1015_7aaa, 0x19b2);             /* call 0x10157aaa */
            ii(0x1015_60f8, 5); calld(0x1016_4b38, 0xea3b);             /* call 0x10164b38 */
            ii(0x1015_60fd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_60fe, 5); mov(eax, StringDefinitions.ResearchCentersInvestigateWaysToImproveYourUnitsUnlikeUpgradesPurchasedWithRefinedGoldResearchTakesTimeAndTheImprovementsAreSmal); /* mov eax, 0x101af5df */
            ii(0x1015_6103, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6104, 5); mov(eax, StringDefinitions.ResearchCenters); /* mov eax, 0x101af738 */
            ii(0x1015_6109, 1); pushd(eax);                             /* push eax */
            ii(0x1015_610a, 5); mov(eax, StringDefinitions.ResearchCenter); /* mov eax, 0x101af749 */
            ii(0x1015_610f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6110, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6115, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6116, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6118, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6119, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_611e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_611f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6124, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6125, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_612a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_612b, 5); mov(eax, 0x35c);                        /* mov eax, 0x35c */
            ii(0x1015_6130, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6131, 5); mov(eax, 0x708);                        /* mov eax, 0x708 */
            ii(0x1015_6136, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6137, 5); mov(eax, 0x47e);                        /* mov eax, 0x47e */
            ii(0x1015_613c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_613d, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_6142, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6143, 5); mov(ecx, 0x79);                         /* mov ecx, 0x79 */
            ii(0x1015_6148, 5); mov(ebx, 0x1d);                         /* mov ebx, 0x1d */
            ii(0x1015_614d, 5); mov(edx, 0x160_4210);                   /* mov edx, 0x1604210 */
            ii(0x1015_6152, 5); mov(eax, 0x101c_99a7);                  /* mov eax, 0x101c99a7 */
            ii(0x1015_6157, 5); calld(0x1015_7aaa, 0x194e);             /* call 0x10157aaa */
            ii(0x1015_615c, 5); calld(0x1016_4b38, 0xe9d7);             /* call 0x10164b38 */
            ii(0x1015_6161, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6162, 5); mov(eax, StringDefinitions.DomedBuildingContainingAnEarthlikeEnvironmentYourUltimateGoalIsToProvideAsManyOfTheseForYourColonistsAsPossibleEveryTurnAnEcosph); /* mov eax, 0x101af759 */
            ii(0x1015_6167, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6168, 5); mov(eax, StringDefinitions.EcoSpheres2); /* mov eax, 0x101af8be */
            ii(0x1015_616d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_616e, 5); mov(eax, StringDefinitions.EcoSphere2); /* mov eax, 0x101af8ca */
            ii(0x1015_6173, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6174, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6179, 1); pushd(eax);                             /* push eax */
            ii(0x1015_617a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_617c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_617d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6182, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6183, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6188, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6189, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_618e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_618f, 5); mov(eax, 0x35d);                        /* mov eax, 0x35d */
            ii(0x1015_6194, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6195, 5); mov(eax, 0x709);                        /* mov eax, 0x709 */
            ii(0x1015_619a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_619b, 5); mov(eax, 0x47f);                        /* mov eax, 0x47f */
            ii(0x1015_61a0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61a1, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_61a6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61a7, 5); mov(ecx, 0x7a);                         /* mov ecx, 0x7a */
            ii(0x1015_61ac, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1015_61b1, 5); mov(edx, 0x160_4210);                   /* mov edx, 0x1604210 */
            ii(0x1015_61b6, 5); mov(eax, 0x101c_99d2);                  /* mov eax, 0x101c99d2 */
            ii(0x1015_61bb, 5); calld(0x1015_7aaa, 0x18ea);             /* call 0x10157aaa */
            ii(0x1015_61c0, 5); calld(0x1016_4b38, 0xe973);             /* call 0x10164b38 */
            ii(0x1015_61c5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61c6, 5); mov(eax, StringDefinitions.Empty33);    /* mov eax, 0x101af8d5 */
            ii(0x1015_61cb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61cc, 5); mov(eax, StringDefinitions.RecreationCenters); /* mov eax, 0x101af8d6 */
            ii(0x1015_61d1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61d2, 5); mov(eax, StringDefinitions.RecreationCenter); /* mov eax, 0x101af8e9 */
            ii(0x1015_61d7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61d8, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_61dd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61de, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_61e0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61e1, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_61e6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61e7, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_61ec, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61ed, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_61f2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61f3, 5); mov(eax, 0x35e);                        /* mov eax, 0x35e */
            ii(0x1015_61f8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61f9, 5); mov(eax, 0x70a);                        /* mov eax, 0x70a */
            ii(0x1015_61fe, 1); pushd(eax);                             /* push eax */
            ii(0x1015_61ff, 5); mov(eax, 0x480);                        /* mov eax, 0x480 */
            ii(0x1015_6204, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6205, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_620a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_620b, 5); mov(ecx, 0x7b);                         /* mov ecx, 0x7b */
            ii(0x1015_6210, 5); mov(ebx, 0x1f);                         /* mov ebx, 0x1f */
            ii(0x1015_6215, 5); mov(edx, 0x100_0210);                   /* mov edx, 0x1000210 */
            ii(0x1015_621a, 5); mov(eax, 0x101c_99fd);                  /* mov eax, 0x101c99fd */
            ii(0x1015_621f, 5); calld(0x1015_7aaa, 0x1886);             /* call 0x10157aaa */
            ii(0x1015_6224, 5); calld(0x1016_4b38, 0xe90f);             /* call 0x10164b38 */
            ii(0x1015_6229, 1); pushd(eax);                             /* push eax */
            ii(0x1015_622a, 5); mov(eax, StringDefinitions.TrainsInfiltratorsWhoCanDisableOrCaptureEnemyUnitsAndInfantryToGuardAgainstInfiltratorsOnlyInfantryAndOtherInfiltratorsCanDetect); /* mov eax, 0x101af8fb */
            ii(0x1015_622f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6230, 5); mov(eax, StringDefinitions.TrainingHalls); /* mov eax, 0x101af9eb */
            ii(0x1015_6235, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6236, 5); mov(eax, StringDefinitions.TrainingHall); /* mov eax, 0x101af9fa */
            ii(0x1015_623b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_623c, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6241, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6242, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6244, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6245, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_624a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_624b, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6250, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6251, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6256, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6257, 5); mov(eax, 0x35f);                        /* mov eax, 0x35f */
            ii(0x1015_625c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_625d, 5); mov(eax, 0x70b);                        /* mov eax, 0x70b */
            ii(0x1015_6262, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6263, 5); mov(eax, 0x481);                        /* mov eax, 0x481 */
            ii(0x1015_6268, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6269, 5); mov(eax, 0x2df);                        /* mov eax, 0x2df */
            ii(0x1015_626e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_626f, 5); mov(ecx, 0x7c);                         /* mov ecx, 0x7c */
            ii(0x1015_6274, 5); mov(ebx, 0x20);                         /* mov ebx, 0x20 */
            ii(0x1015_6279, 5); mov(edx, 0x160_4210);                   /* mov edx, 0x1604210 */
            ii(0x1015_627e, 5); mov(eax, 0x101c_9a28);                  /* mov eax, 0x101c9a28 */
            ii(0x1015_6283, 5); calld(0x1015_7aaa, 0x1822);             /* call 0x10157aaa */
            ii(0x1015_6288, 5); calld(0x1016_4b38, 0xe8ab);             /* call 0x10164b38 */
            ii(0x1015_628d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_628e, 5); mov(eax, StringDefinitions.ProvidesASurfaceOverWaterOnWhichToConstructOtherBuildingsEngineersCanBuildWaterPlatformsOverShoreAsWellAsOpenWaterWaterPlatforms); /* mov eax, 0x101afa08 */
            ii(0x1015_6293, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6294, 5); mov(eax, StringDefinitions.WaterPlatforms); /* mov eax, 0x101afb04 */
            ii(0x1015_6299, 1); pushd(eax);                             /* push eax */
            ii(0x1015_629a, 5); mov(eax, StringDefinitions.WaterPlatform); /* mov eax, 0x101afb14 */
            ii(0x1015_629f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62a0, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_62a5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62a6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_62a8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62a9, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1015_62ae, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62af, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_62b4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62b5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_62ba, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62bb, 5); mov(eax, 0x360);                        /* mov eax, 0x360 */
            ii(0x1015_62c0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62c1, 5); mov(eax, 0x70c);                        /* mov eax, 0x70c */
            ii(0x1015_62c6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62c7, 5); mov(eax, 0x482);                        /* mov eax, 0x482 */
            ii(0x1015_62cc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62cd, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_62d2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62d3, 5); mov(ecx, 0x7d);                         /* mov ecx, 0x7d */
            ii(0x1015_62d8, 5); mov(ebx, 0x21);                         /* mov ebx, 0x21 */
            ii(0x1015_62dd, 5); mov(edx, 0x40_4201);                    /* mov edx, 0x404201 */
            ii(0x1015_62e2, 5); mov(eax, 0x101c_9a53);                  /* mov eax, 0x101c9a53 */
            ii(0x1015_62e7, 5); calld(0x1015_7aaa, 0x17be);             /* call 0x10157aaa */
            ii(0x1015_62ec, 5); mov(eax, StringDefinitions.GunTurretsFireAutomaticallyOnEnemyUnitsOfCourseTheyCanTFireOnWhatTheyCanTSeeSoItSImportantToHaveAScoutScannerOrRadarNearby); /* mov eax, 0x101afb23 */
            ii(0x1015_62f1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62f2, 5); mov(eax, StringDefinitions.HeavilyArmoredStationaryGunTurretGunTurretsHaveGoodFirepowerHeavyArmorAndModerateRangeBecauseTheyTakeLittleTimeToBuildTheyAreAGo); /* mov eax, 0x101afbc2 */
            ii(0x1015_62f7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62f8, 5); mov(eax, StringDefinitions.GunTurrets); /* mov eax, 0x101afc8e */
            ii(0x1015_62fd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_62fe, 5); mov(eax, StringDefinitions.GunTurret);  /* mov eax, 0x101afc9a */
            ii(0x1015_6303, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6304, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6309, 1); pushd(eax);                             /* push eax */
            ii(0x1015_630a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_630c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_630d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6312, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6313, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6318, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6319, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_631e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_631f, 5); mov(eax, 0x361);                        /* mov eax, 0x361 */
            ii(0x1015_6324, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6325, 5); mov(eax, 0x70d);                        /* mov eax, 0x70d */
            ii(0x1015_632a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_632b, 5); mov(eax, 0x483);                        /* mov eax, 0x483 */
            ii(0x1015_6330, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6331, 5); mov(eax, 0x2e5);                        /* mov eax, 0x2e5 */
            ii(0x1015_6336, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6337, 5); mov(ecx, 0x7e);                         /* mov ecx, 0x7e */
            ii(0x1015_633c, 5); mov(ebx, 0x22);                         /* mov ebx, 0x22 */
            ii(0x1015_6341, 5); mov(edx, 0x7e2_4200);                   /* mov edx, 0x7e24200 */
            ii(0x1015_6346, 5); mov(eax, 0x101c_9a7e);                  /* mov eax, 0x101c9a7e */
            ii(0x1015_634b, 5); calld(0x1015_7aaa, 0x175a);             /* call 0x10157aaa */
            ii(0x1015_6350, 5); calld(0x1016_4b38, 0xe7e3);             /* call 0x10164b38 */
            ii(0x1015_6355, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6356, 5); mov(eax, StringDefinitions.LowCaliberHighSpeedAntiAircraftCannonAntiAircraftMakeShortWorkOfPlanesButCannotAttackGroundUnits); /* mov eax, 0x101afca5 */
            ii(0x1015_635b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_635c, 5); mov(eax, StringDefinitions.AntiAircraft); /* mov eax, 0x101afd1e */
            ii(0x1015_6361, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6362, 5); mov(eax, StringDefinitions.AntiAircraft2); /* mov eax, 0x101afd2c */
            ii(0x1015_6367, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6368, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_636d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_636e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6370, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6371, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6376, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6377, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_637c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_637d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6382, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6383, 5); mov(eax, 0x362);                        /* mov eax, 0x362 */
            ii(0x1015_6388, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6389, 5); mov(eax, 0x70e);                        /* mov eax, 0x70e */
            ii(0x1015_638e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_638f, 5); mov(eax, 0x484);                        /* mov eax, 0x484 */
            ii(0x1015_6394, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6395, 5); mov(eax, 0x2e4);                        /* mov eax, 0x2e4 */
            ii(0x1015_639a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_639b, 5); mov(ecx, 0x7f);                         /* mov ecx, 0x7f */
            ii(0x1015_63a0, 5); mov(ebx, 0x23);                         /* mov ebx, 0x23 */
            ii(0x1015_63a5, 5); mov(edx, 0x7e2_4200);                   /* mov edx, 0x7e24200 */
            ii(0x1015_63aa, 5); mov(eax, 0x101c_9aa9);                  /* mov eax, 0x101c9aa9 */
            ii(0x1015_63af, 5); calld(0x1015_7aaa, 0x16f6);             /* call 0x10157aaa */
            ii(0x1015_63b4, 5); calld(0x1016_4b38, 0xe77f);             /* call 0x10164b38 */
            ii(0x1015_63b9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63ba, 5); mov(eax, StringDefinitions.HighPoweredStationaryGunArtilleryIsACompromiseBetweenTheCheapRuggedGunTurretAndTheExpensiveLongRangeMissileTurret); /* mov eax, 0x101afd3a */
            ii(0x1015_63bf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63c0, 5); mov(eax, StringDefinitions.Artillery);  /* mov eax, 0x101afdc5 */
            ii(0x1015_63c5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63c6, 5); mov(eax, StringDefinitions.Artillery2); /* mov eax, 0x101afdcf */
            ii(0x1015_63cb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63cc, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_63d1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63d2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_63d4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63d5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_63da, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63db, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_63e0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63e1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_63e6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63e7, 5); mov(eax, 0x363);                        /* mov eax, 0x363 */
            ii(0x1015_63ec, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63ed, 5); mov(eax, 0x70f);                        /* mov eax, 0x70f */
            ii(0x1015_63f2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63f3, 5); mov(eax, 0x485);                        /* mov eax, 0x485 */
            ii(0x1015_63f8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63f9, 5); mov(eax, 0x2e5);                        /* mov eax, 0x2e5 */
            ii(0x1015_63fe, 1); pushd(eax);                             /* push eax */
            ii(0x1015_63ff, 5); mov(ecx, 0x80);                         /* mov ecx, 0x80 */
            ii(0x1015_6404, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x1015_6409, 5); mov(edx, 0x7e2_4200);                   /* mov edx, 0x7e24200 */
            ii(0x1015_640e, 5); mov(eax, 0x101c_9ad4);                  /* mov eax, 0x101c9ad4 */
            ii(0x1015_6413, 5); calld(0x1015_7aaa, 0x1692);             /* call 0x10157aaa */
            ii(0x1015_6418, 5); calld(0x1016_4b38, 0xe71b);             /* call 0x10164b38 */
            ii(0x1015_641d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_641e, 5); mov(eax, StringDefinitions.LongRangeMissileLauncherOnAFixedMountExcellentRangeAndFirepowerButOnlySlightlyMoreArmorThanTheMobileVersionBestSurroundedByGunTu); /* mov eax, 0x101afdd9 */
            ii(0x1015_6423, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6424, 5); mov(eax, StringDefinitions.MissileLaunchers); /* mov eax, 0x101afe8f */
            ii(0x1015_6429, 1); pushd(eax);                             /* push eax */
            ii(0x1015_642a, 5); mov(eax, StringDefinitions.MissileLauncher); /* mov eax, 0x101afea1 */
            ii(0x1015_642f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6430, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6435, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6436, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6438, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6439, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_643e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_643f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6444, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6445, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_644a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_644b, 5); mov(eax, 0x364);                        /* mov eax, 0x364 */
            ii(0x1015_6450, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6451, 5); mov(eax, 0x710);                        /* mov eax, 0x710 */
            ii(0x1015_6456, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6457, 5); mov(eax, 0x486);                        /* mov eax, 0x486 */
            ii(0x1015_645c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_645d, 5); mov(eax, 0x2e5);                        /* mov eax, 0x2e5 */
            ii(0x1015_6462, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6463, 5); mov(ecx, 0x81);                         /* mov ecx, 0x81 */
            ii(0x1015_6468, 5); mov(ebx, 0x25);                         /* mov ebx, 0x25 */
            ii(0x1015_646d, 5); mov(edx, 0x7e6_4200);                   /* mov edx, 0x7e64200 */
            ii(0x1015_6472, 5); mov(eax, 0x101c_9aff);                  /* mov eax, 0x101c9aff */
            ii(0x1015_6477, 5); calld(0x1015_7aaa, 0x162e);             /* call 0x10157aaa */
            ii(0x1015_647c, 5); calld(0x1016_4b38, 0xe6b7);             /* call 0x10164b38 */
            ii(0x1015_6481, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6482, 5); mov(eax, StringDefinitions.HardenedArmoredBlockForBlockingEnemyMovement); /* mov eax, 0x101afeb2 */
            ii(0x1015_6487, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6488, 5); mov(eax, StringDefinitions.ConcreteBlocks); /* mov eax, 0x101afee7 */
            ii(0x1015_648d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_648e, 5); mov(eax, StringDefinitions.ConcreteBlock); /* mov eax, 0x101afef7 */
            ii(0x1015_6493, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6494, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6499, 1); pushd(eax);                             /* push eax */
            ii(0x1015_649a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_649c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_649d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_64a2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64a3, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_64a8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64a9, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_64ae, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64af, 5); mov(eax, 0x365);                        /* mov eax, 0x365 */
            ii(0x1015_64b4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64b5, 5); mov(eax, 0x711);                        /* mov eax, 0x711 */
            ii(0x1015_64ba, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64bb, 5); mov(eax, 0x487);                        /* mov eax, 0x487 */
            ii(0x1015_64c0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64c1, 5); mov(eax, 0x2e0);                        /* mov eax, 0x2e0 */
            ii(0x1015_64c6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64c7, 5); mov(ecx, 0x82);                         /* mov ecx, 0x82 */
            ii(0x1015_64cc, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1015_64d1, 5); mov(edx, 0xc0_4200);                    /* mov edx, 0xc04200 */
            ii(0x1015_64d6, 5); mov(eax, 0x101c_9b2a);                  /* mov eax, 0x101c9b2a */
            ii(0x1015_64db, 5); calld(0x1015_7aaa, 0x15ca);             /* call 0x10157aaa */
            ii(0x1015_64e0, 5); calld(0x1016_4b38, 0xe653);             /* call 0x10164b38 */
            ii(0x1015_64e5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64e6, 5); mov(eax, StringDefinitions.PontoonBridgeForCrossingWaterBridgesUnlikeWaterPlatformsDoNotBlockTheMovementOfShips); /* mov eax, 0x101aff06 */
            ii(0x1015_64eb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64ec, 5); mov(eax, StringDefinitions.Bridges);    /* mov eax, 0x101aff6f */
            ii(0x1015_64f1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64f2, 5); mov(eax, StringDefinitions.Bridge);     /* mov eax, 0x101aff77 */
            ii(0x1015_64f7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64f8, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_64fd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_64fe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6500, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6501, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1015_6506, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6507, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_650c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_650d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6512, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6513, 5); mov(eax, 0x366);                        /* mov eax, 0x366 */
            ii(0x1015_6518, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6519, 5); mov(eax, 0x712);                        /* mov eax, 0x712 */
            ii(0x1015_651e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_651f, 5); mov(eax, 0x488);                        /* mov eax, 0x488 */
            ii(0x1015_6524, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6525, 5); mov(eax, 0x2f4);                        /* mov eax, 0x2f4 */
            ii(0x1015_652a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_652b, 5); mov(ecx, 0x83);                         /* mov ecx, 0x83 */
            ii(0x1015_6530, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1015_6535, 5); mov(edx, 0x40_4201);                    /* mov edx, 0x404201 */
            ii(0x1015_653a, 5); mov(eax, 0x101c_9b55);                  /* mov eax, 0x101c9b55 */
            ii(0x1015_653f, 5); calld(0x1015_7aaa, 0x1566);             /* call 0x10157aaa */
            ii(0x1015_6544, 5); mov(eax, StringDefinitions.AMiningStationProducesRawMaterialsFuelAndGoldEveryTurnBuildingsMustBeConnectedToTheMineToUseTheResourcesTheMineProduces); /* mov eax, 0x101aff7e */
            ii(0x1015_6549, 1); pushd(eax);                             /* push eax */
            ii(0x1015_654a, 5); mov(eax, StringDefinitions.ExtractsRawMaterialsFuelAndGoldFromTheGroundEveryTurnBuildingsMustBeConnectedToAMineToUseTheResourcesAMineProducesIfThereAreNoSt); /* mov eax, 0x101b0013 */
            ii(0x1015_654f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6550, 5); mov(eax, StringDefinitions.MiningStations); /* mov eax, 0x101b011b */
            ii(0x1015_6555, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6556, 5); mov(eax, StringDefinitions.MiningStation); /* mov eax, 0x101b012b */
            ii(0x1015_655b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_655c, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6561, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6562, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6567, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6568, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_656d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_656e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6573, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6574, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6579, 1); pushd(eax);                             /* push eax */
            ii(0x1015_657a, 5); mov(eax, 0x367);                        /* mov eax, 0x367 */
            ii(0x1015_657f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6580, 5); mov(eax, 0x713);                        /* mov eax, 0x713 */
            ii(0x1015_6585, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6586, 5); mov(eax, 0x489);                        /* mov eax, 0x489 */
            ii(0x1015_658b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_658c, 5); mov(eax, 0x2fb);                        /* mov eax, 0x2fb */
            ii(0x1015_6591, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6592, 5); mov(ecx, 0x84);                         /* mov ecx, 0x84 */
            ii(0x1015_6597, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1015_659c, 5); mov(edx, 0x160_4210);                   /* mov edx, 0x1604210 */
            ii(0x1015_65a1, 5); mov(eax, 0x101c_9b80);                  /* mov eax, 0x101c9b80 */
            ii(0x1015_65a6, 5); calld(0x1015_7aaa, 0x14ff);             /* call 0x10157aaa */
            ii(0x1015_65ab, 5); calld(0x1016_4b38, 0xe588);             /* call 0x10164b38 */
            ii(0x1015_65b0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65b1, 5); mov(eax, StringDefinitions.SmallHardToDetectExplosiveDeviceOnlySurveyorsMinelayersAndInfiltratorsCanSpotMinesOnceSpottedAlmostAnyDamageWillDestroyIt); /* mov eax, 0x101b013a */
            ii(0x1015_65b6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65b7, 5); mov(eax, StringDefinitions.LandMines);  /* mov eax, 0x101b01d2 */
            ii(0x1015_65bc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65bd, 5); mov(eax, StringDefinitions.LandMine);   /* mov eax, 0x101b01dd */
            ii(0x1015_65c2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65c3, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_65c8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65c9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_65cb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65cc, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_65d1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65d2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_65d7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65d8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_65dd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65de, 5); mov(eax, 0x368);                        /* mov eax, 0x368 */
            ii(0x1015_65e3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65e4, 5); mov(eax, 0x714);                        /* mov eax, 0x714 */
            ii(0x1015_65e9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65ea, 5); mov(eax, 0x48a);                        /* mov eax, 0x48a */
            ii(0x1015_65ef, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65f0, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_65f5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_65f6, 5); mov(ecx, 0x85);                         /* mov ecx, 0x85 */
            ii(0x1015_65fb, 5); mov(ebx, 0x29);                         /* mov ebx, 0x29 */
            ii(0x1015_6600, 5); mov(edx, 0x440_4201);                   /* mov edx, 0x4404201 */
            ii(0x1015_6605, 5); mov(eax, 0x101c_9bab);                  /* mov eax, 0x101c9bab */
            ii(0x1015_660a, 5); calld(0x1015_7aaa, 0x149b);             /* call 0x10157aaa */
            ii(0x1015_660f, 5); calld(0x1016_4b38, 0xe524);             /* call 0x10164b38 */
            ii(0x1015_6614, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6615, 5); mov(eax, StringDefinitions.SmallHardToDetectExplosiveDeviceOnlySurveyorsMinelayersAndInfiltratorsCanSpotMinesOnceSpottedAlmostAnyDamageWillDestroyIt2); /* mov eax, 0x101b01e7 */
            ii(0x1015_661a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_661b, 5); mov(eax, StringDefinitions.SeaMines);   /* mov eax, 0x101b027f */
            ii(0x1015_6620, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6621, 5); mov(eax, StringDefinitions.SeaMine);    /* mov eax, 0x101b0289 */
            ii(0x1015_6626, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6627, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_662c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_662d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_662f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6630, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_6635, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6636, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_663b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_663c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6641, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6642, 5); mov(eax, 0x369);                        /* mov eax, 0x369 */
            ii(0x1015_6647, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6648, 5); mov(eax, 0x715);                        /* mov eax, 0x715 */
            ii(0x1015_664d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_664e, 5); mov(eax, 0x48b);                        /* mov eax, 0x48b */
            ii(0x1015_6653, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6654, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_6659, 1); pushd(eax);                             /* push eax */
            ii(0x1015_665a, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_665f, 5); mov(ebx, 0x2a);                         /* mov ebx, 0x2a */
            ii(0x1015_6664, 5); mov(edx, 0x440_4201);                   /* mov edx, 0x4404201 */
            ii(0x1015_6669, 5); mov(eax, 0x101c_9bd6);                  /* mov eax, 0x101c9bd6 */
            ii(0x1015_666e, 5); calld(0x1015_7aaa, 0x1437);             /* call 0x10157aaa */
            ii(0x1015_6673, 5); calld(0x1016_4b38, 0xe4c0);             /* call 0x10164b38 */
            ii(0x1015_6678, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6679, 5); mov(eax, StringDefinitions.Empty34);    /* mov eax, 0x101b0292 */
            ii(0x1015_667e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_667f, 5); mov(eax, StringDefinitions.Empty35);    /* mov eax, 0x101b0293 */
            ii(0x1015_6684, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6685, 5); mov(eax, StringDefinitions.Explosion);  /* mov eax, 0x101b0294 */
            ii(0x1015_668a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_668b, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6690, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6691, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6693, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6694, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_6699, 1); pushd(eax);                             /* push eax */
            ii(0x1015_669a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_669f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66a0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_66a5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66a6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_66ab, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66ac, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_66b1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66b2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_66b7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66b8, 5); mov(eax, 0x2e9);                        /* mov eax, 0x2e9 */
            ii(0x1015_66bd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66be, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_66c3, 5); mov(ebx, 0x2b);                         /* mov ebx, 0x2b */
            ii(0x1015_66c8, 5); mov(edx, 0x206);                        /* mov edx, 0x206 */
            ii(0x1015_66cd, 5); mov(eax, 0x101c_9c01);                  /* mov eax, 0x101c9c01 */
            ii(0x1015_66d2, 5); calld(0x1015_7aaa, 0x13d3);             /* call 0x10157aaa */
            ii(0x1015_66d7, 5); calld(0x1016_4b38, 0xe45c);             /* call 0x10164b38 */
            ii(0x1015_66dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66dd, 5); mov(eax, StringDefinitions.Empty36);    /* mov eax, 0x101b029e */
            ii(0x1015_66e2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66e3, 5); mov(eax, StringDefinitions.Empty37);    /* mov eax, 0x101b029f */
            ii(0x1015_66e8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66e9, 5); mov(eax, StringDefinitions.Explosion2); /* mov eax, 0x101b02a0 */
            ii(0x1015_66ee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66ef, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_66f4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66f5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_66f7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66f8, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_66fd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_66fe, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6703, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6704, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6709, 1); pushd(eax);                             /* push eax */
            ii(0x1015_670a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_670f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6710, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6715, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6716, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_671b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_671c, 5); mov(eax, 0x2e9);                        /* mov eax, 0x2e9 */
            ii(0x1015_6721, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6722, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_6727, 5); mov(ebx, 0x2c);                         /* mov ebx, 0x2c */
            ii(0x1015_672c, 5); mov(edx, 0x206);                        /* mov edx, 0x206 */
            ii(0x1015_6731, 5); mov(eax, 0x101c_9c2c);                  /* mov eax, 0x101c9c2c */
            ii(0x1015_6736, 5); calld(0x1015_7aaa, 0x136f);             /* call 0x10157aaa */
            ii(0x1015_673b, 5); calld(0x1016_4b38, 0xe3f8);             /* call 0x10164b38 */
            ii(0x1015_6740, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6741, 5); mov(eax, StringDefinitions.Empty38);    /* mov eax, 0x101b02aa */
            ii(0x1015_6746, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6747, 5); mov(eax, StringDefinitions.Empty39);    /* mov eax, 0x101b02ab */
            ii(0x1015_674c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_674d, 5); mov(eax, StringDefinitions.Explosion3); /* mov eax, 0x101b02ac */
            ii(0x1015_6752, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6753, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6758, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6759, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_675b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_675c, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_6761, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6762, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6767, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6768, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_676d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_676e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6773, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6774, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6779, 1); pushd(eax);                             /* push eax */
            ii(0x1015_677a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_677f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6780, 5); mov(eax, 0x2e9);                        /* mov eax, 0x2e9 */
            ii(0x1015_6785, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6786, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_678b, 5); mov(ebx, 0x2d);                         /* mov ebx, 0x2d */
            ii(0x1015_6790, 5); mov(edx, 0x206);                        /* mov edx, 0x206 */
            ii(0x1015_6795, 5); mov(eax, 0x101c_9c57);                  /* mov eax, 0x101c9c57 */
            ii(0x1015_679a, 5); calld(0x1015_7aaa, 0x130b);             /* call 0x10157aaa */
            ii(0x1015_679f, 5); calld(0x1016_4b38, 0xe394);             /* call 0x10164b38 */
            ii(0x1015_67a4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67a5, 5); mov(eax, StringDefinitions.Empty40);    /* mov eax, 0x101b02b6 */
            ii(0x1015_67aa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67ab, 5); mov(eax, StringDefinitions.Empty41);    /* mov eax, 0x101b02b7 */
            ii(0x1015_67b0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67b1, 5); mov(eax, StringDefinitions.Explosion4); /* mov eax, 0x101b02b8 */
            ii(0x1015_67b6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67b7, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_67bc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67bd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_67bf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67c0, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_67c5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67c6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_67cb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67cc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_67d1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67d2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_67d7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67d8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_67dd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67de, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_67e3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67e4, 5); mov(eax, 0x2eb);                        /* mov eax, 0x2eb */
            ii(0x1015_67e9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_67ea, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_67ef, 5); mov(ebx, 0x2e);                         /* mov ebx, 0x2e */
            ii(0x1015_67f4, 5); mov(edx, 0x206);                        /* mov edx, 0x206 */
            ii(0x1015_67f9, 5); mov(eax, 0x101c_9c82);                  /* mov eax, 0x101c9c82 */
            ii(0x1015_67fe, 5); calld(0x1015_7aaa, 0x12a7);             /* call 0x10157aaa */
            ii(0x1015_6803, 5); calld(0x1016_4b38, 0xe330);             /* call 0x10164b38 */
            ii(0x1015_6808, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6809, 5); mov(eax, StringDefinitions.Empty42);    /* mov eax, 0x101b02c2 */
            ii(0x1015_680e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_680f, 5); mov(eax, StringDefinitions.Empty43);    /* mov eax, 0x101b02c3 */
            ii(0x1015_6814, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6815, 5); mov(eax, StringDefinitions.Explosion5); /* mov eax, 0x101b02c4 */
            ii(0x1015_681a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_681b, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6820, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6821, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6823, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6824, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_6829, 1); pushd(eax);                             /* push eax */
            ii(0x1015_682a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_682f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6830, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6835, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6836, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_683b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_683c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6841, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6842, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6847, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6848, 5); mov(eax, 0x2ea);                        /* mov eax, 0x2ea */
            ii(0x1015_684d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_684e, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_6853, 5); mov(ebx, 0x2f);                         /* mov ebx, 0x2f */
            ii(0x1015_6858, 5); mov(edx, 0x206);                        /* mov edx, 0x206 */
            ii(0x1015_685d, 5); mov(eax, 0x101c_9cad);                  /* mov eax, 0x101c9cad */
            ii(0x1015_6862, 5); calld(0x1015_7aaa, 0x1243);             /* call 0x10157aaa */
            ii(0x1015_6867, 5); calld(0x1016_4b38, 0xe2cc);             /* call 0x10164b38 */
            ii(0x1015_686c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_686d, 5); mov(eax, StringDefinitions.SpecializedVehicleWhichTransformsToBecomeANewMiningStation); /* mov eax, 0x101b02ce */
            ii(0x1015_6872, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6873, 5); mov(eax, StringDefinitions.MasterBuilders); /* mov eax, 0x101b0313 */
            ii(0x1015_6878, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6879, 5); mov(eax, StringDefinitions.MasterBuilder); /* mov eax, 0x101b0323 */
            ii(0x1015_687e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_687f, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6884, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6885, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6887, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6888, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_688d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_688e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6893, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6894, 5); mov(eax, 0x73a);                        /* mov eax, 0x73a */
            ii(0x1015_6899, 1); pushd(eax);                             /* push eax */
            ii(0x1015_689a, 5); mov(eax, 0x36a);                        /* mov eax, 0x36a */
            ii(0x1015_689f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68a0, 5); mov(eax, 0x716);                        /* mov eax, 0x716 */
            ii(0x1015_68a5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68a6, 5); mov(eax, 0x48c);                        /* mov eax, 0x48c */
            ii(0x1015_68ab, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68ac, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_68b1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68b2, 5); mov(ecx, 0x87);                         /* mov ecx, 0x87 */
            ii(0x1015_68b7, 5); mov(ebx, 0x30);                         /* mov ebx, 0x30 */
            ii(0x1015_68bc, 5); mov(edx, 0x460_0100);                   /* mov edx, 0x4600100 */
            ii(0x1015_68c1, 5); mov(eax, 0x101c_9cd8);                  /* mov eax, 0x101c9cd8 */
            ii(0x1015_68c6, 5); calld(0x1015_7aaa, 0x11df);             /* call 0x10157aaa */
            ii(0x1015_68cb, 5); mov(eax, StringDefinitions.ConstructorsBuildLargeBuildingsLikeFactoriesClickOnceOnTheConstructorToSelectItClickASecondTimeToShowTheBuildButton); /* mov eax, 0x101b0332 */
            ii(0x1015_68d0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68d1, 5); mov(eax, StringDefinitions.LargeConstructionVehicleForCreatingLargeBuildingsSuchAsMinesAndFactoriesAConstructorConsumesTwoMaterialPerTurnWhileOperating); /* mov eax, 0x101b03c0 */
            ii(0x1015_68d6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68d7, 5); mov(eax, StringDefinitions.Constructors); /* mov eax, 0x101b0455 */
            ii(0x1015_68dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68dd, 5); mov(eax, StringDefinitions.Constructor); /* mov eax, 0x101b0462 */
            ii(0x1015_68e2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68e3, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_68e8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68e9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_68ee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68ef, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_68f4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68f5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_68fa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_68fb, 5); mov(eax, 0x73b);                        /* mov eax, 0x73b */
            ii(0x1015_6900, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6901, 5); mov(eax, 0x36b);                        /* mov eax, 0x36b */
            ii(0x1015_6906, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6907, 5); mov(eax, 0x717);                        /* mov eax, 0x717 */
            ii(0x1015_690c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_690d, 5); mov(eax, 0x48d);                        /* mov eax, 0x48d */
            ii(0x1015_6912, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6913, 5); mov(eax, 0x2f2);                        /* mov eax, 0x2f2 */
            ii(0x1015_6918, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6919, 5); mov(ecx, 0x88);                         /* mov ecx, 0x88 */
            ii(0x1015_691e, 5); mov(ebx, 0x31);                         /* mov ebx, 0x31 */
            ii(0x1015_6923, 5); mov(edx, 0x468_4180);                   /* mov edx, 0x4684180 */
            ii(0x1015_6928, 5); mov(eax, 0x101c_9d03);                  /* mov eax, 0x101c9d03 */
            ii(0x1015_692d, 5); calld(0x1015_7aaa, 0x1178);             /* call 0x10157aaa */
            ii(0x1015_6932, 5); mov(eax, StringDefinitions.AScoutCanSeeALongWayAndIsVeryFastItAlsoHasASmallGunForHarassingTheEnemyToMoveTheScoutClickOnItAndThenClickWhereYouWantToMoveToAt); /* mov eax, 0x101b046e */
            ii(0x1015_6937, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6938, 5); mov(eax, StringDefinitions.HighSpeedScoutingVehicleForExplorationAndSpottingEnemyUnitsCanCrossWaterWithoutABridgeButIsFasterOnLandVeryFastAndGoodScanRangeB); /* mov eax, 0x101b055e */
            ii(0x1015_693d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_693e, 5); mov(eax, StringDefinitions.Scouts);     /* mov eax, 0x101b0626 */
            ii(0x1015_6943, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6944, 5); mov(eax, StringDefinitions.Scout);      /* mov eax, 0x101b062d */
            ii(0x1015_6949, 1); pushd(eax);                             /* push eax */
            ii(0x1015_694a, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_694f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6950, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6952, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6953, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_6958, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6959, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_695e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_695f, 5); mov(eax, 0x73c);                        /* mov eax, 0x73c */
            ii(0x1015_6964, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6965, 5); mov(eax, 0x36c);                        /* mov eax, 0x36c */
            ii(0x1015_696a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_696b, 5); mov(eax, 0x718);                        /* mov eax, 0x718 */
            ii(0x1015_6970, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6971, 5); mov(eax, 0x48e);                        /* mov eax, 0x48e */
            ii(0x1015_6976, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6977, 5); mov(eax, 0x2f2);                        /* mov eax, 0x2f2 */
            ii(0x1015_697c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_697d, 5); mov(ecx, 0x89);                         /* mov ecx, 0x89 */
            ii(0x1015_6982, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1015_6987, 5); mov(edx, 0x462_4180);                   /* mov edx, 0x4624180 */
            ii(0x1015_698c, 5); mov(eax, 0x101c_9d2e);                  /* mov eax, 0x101c9d2e */
            ii(0x1015_6991, 5); calld(0x1015_7aaa, 0x1114);             /* call 0x10157aaa */
            ii(0x1015_6996, 5); mov(eax, StringDefinitions.TanksAreBigAndToughButNotAsFastAsScoutsLikeMostUnitsTanksCanEitherMoveOrFireButNotAlwaysBothIfYouDonTMoveATankItCanFireTwiceEach); /* mov eax, 0x101b0633 */
            ii(0x1015_699b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_699c, 5); mov(eax, StringDefinitions.HeavilyArmoredFightingVehicleBestUsedInTheFrontLineToPreventEnemyUnitsFromReachingLightlyArmoredSupportUnitsSuchAsAssaultGunsAnd); /* mov eax, 0x101b0746 */
            ii(0x1015_69a1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69a2, 5); mov(eax, StringDefinitions.Tanks);      /* mov eax, 0x101b07f3 */
            ii(0x1015_69a7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69a8, 5); mov(eax, StringDefinitions.Tank);       /* mov eax, 0x101b07f9 */
            ii(0x1015_69ad, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69ae, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_69b3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69b4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_69b6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69b7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_69bc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69bd, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_69c2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69c3, 5); mov(eax, 0x73d);                        /* mov eax, 0x73d */
            ii(0x1015_69c8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69c9, 5); mov(eax, 0x36d);                        /* mov eax, 0x36d */
            ii(0x1015_69ce, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69cf, 5); mov(eax, 0x719);                        /* mov eax, 0x719 */
            ii(0x1015_69d4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69d5, 5); mov(eax, 0x48f);                        /* mov eax, 0x48f */
            ii(0x1015_69da, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69db, 5); mov(eax, 0x2e6);                        /* mov eax, 0x2e6 */
            ii(0x1015_69e0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_69e1, 5); mov(ecx, 0x8a);                         /* mov ecx, 0x8a */
            ii(0x1015_69e6, 5); mov(ebx, 0x33);                         /* mov ebx, 0x33 */
            ii(0x1015_69eb, 5); mov(edx, 0x662_4100);                   /* mov edx, 0x6624100 */
            ii(0x1015_69f0, 5); mov(eax, 0x101c_9d59);                  /* mov eax, 0x101c9d59 */
            ii(0x1015_69f5, 5); calld(0x1015_7aaa, 0x10b0);             /* call 0x10157aaa */
            ii(0x1015_69fa, 5); calld(0x1016_4b38, 0xe139);             /* call 0x10164b38 */
            ii(0x1015_69ff, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a00, 5); mov(eax, StringDefinitions.LightlyArmoredVehicleWithALongRangeGunFiringHighExplosiveShellsFastAndEffectiveOnTheAttackButFragile); /* mov eax, 0x101b07fe */
            ii(0x1015_6a05, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a06, 5); mov(eax, StringDefinitions.AssaultGuns); /* mov eax, 0x101b087a */
            ii(0x1015_6a0b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a0c, 5); mov(eax, StringDefinitions.AssaultGun); /* mov eax, 0x101b0887 */
            ii(0x1015_6a11, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a12, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6a17, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a18, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6a1a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a1b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6a20, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a21, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6a26, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a27, 5); mov(eax, 0x73e);                        /* mov eax, 0x73e */
            ii(0x1015_6a2c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a2d, 5); mov(eax, 0x36e);                        /* mov eax, 0x36e */
            ii(0x1015_6a32, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a33, 5); mov(eax, 0x71a);                        /* mov eax, 0x71a */
            ii(0x1015_6a38, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a39, 5); mov(eax, 0x490);                        /* mov eax, 0x490 */
            ii(0x1015_6a3e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a3f, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_6a44, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a45, 5); mov(ecx, 0x8b);                         /* mov ecx, 0x8b */
            ii(0x1015_6a4a, 5); mov(ebx, 0x34);                         /* mov ebx, 0x34 */
            ii(0x1015_6a4f, 5); mov(edx, 0x462_4100);                   /* mov edx, 0x4624100 */
            ii(0x1015_6a54, 5); mov(eax, 0x101c_9d84);                  /* mov eax, 0x101c9d84 */
            ii(0x1015_6a59, 5); calld(0x1015_7aaa, 0x104c);             /* call 0x10157aaa */
            ii(0x1015_6a5e, 5); calld(0x1016_4b38, 0xe0d5);             /* call 0x10164b38 */
            ii(0x1015_6a63, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a64, 5); mov(eax, StringDefinitions.LightlyArmoredVehicleFiringMediumRangeRocketsWhichAffectAllUnitsWithin2SquaresOfTheTargetMostEffectiveAgainstGroupsOfEnemyUnits); /* mov eax, 0x101b0893 */
            ii(0x1015_6a69, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a6a, 5); mov(eax, StringDefinitions.RocketLaunchers); /* mov eax, 0x101b092d */
            ii(0x1015_6a6f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a70, 5); mov(eax, StringDefinitions.RocketLauncher); /* mov eax, 0x101b093e */
            ii(0x1015_6a75, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a76, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6a7b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a7c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6a7e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a7f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6a84, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a85, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6a8a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a8b, 5); mov(eax, 0x73f);                        /* mov eax, 0x73f */
            ii(0x1015_6a90, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a91, 5); mov(eax, 0x36f);                        /* mov eax, 0x36f */
            ii(0x1015_6a96, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a97, 5); mov(eax, 0x71b);                        /* mov eax, 0x71b */
            ii(0x1015_6a9c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6a9d, 5); mov(eax, 0x491);                        /* mov eax, 0x491 */
            ii(0x1015_6aa2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6aa3, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_6aa8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6aa9, 5); mov(ecx, 0x8c);                         /* mov ecx, 0x8c */
            ii(0x1015_6aae, 5); mov(ebx, 0x35);                         /* mov ebx, 0x35 */
            ii(0x1015_6ab3, 5); mov(edx, 0x466_4100);                   /* mov edx, 0x4664100 */
            ii(0x1015_6ab8, 5); mov(eax, 0x101c_9daf);                  /* mov eax, 0x101c9daf */
            ii(0x1015_6abd, 5); calld(0x1015_7aaa, 0xfe8);              /* call 0x10157aaa */
            ii(0x1015_6ac2, 5); calld(0x1016_4b38, 0xe071);             /* call 0x10164b38 */
            ii(0x1015_6ac7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ac8, 5); mov(eax, StringDefinitions.MissileLauncherOnALightlyArmoredChassisThisMobileLauncherIsSlightlyLessSturdyThanTheStationaryVersionAndRequiresMoreMaterialToBu); /* mov eax, 0x101b094e */
            ii(0x1015_6acd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ace, 5); mov(eax, StringDefinitions.MissileCrawlers); /* mov eax, 0x101b0a28 */
            ii(0x1015_6ad3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ad4, 5); mov(eax, StringDefinitions.MissileCrawler); /* mov eax, 0x101b0a39 */
            ii(0x1015_6ad9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ada, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6adf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ae0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6ae2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ae3, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6ae8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ae9, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6aee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6aef, 5); mov(eax, 0x740);                        /* mov eax, 0x740 */
            ii(0x1015_6af4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6af5, 5); mov(eax, 0x370);                        /* mov eax, 0x370 */
            ii(0x1015_6afa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6afb, 5); mov(eax, 0x71c);                        /* mov eax, 0x71c */
            ii(0x1015_6b00, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b01, 5); mov(eax, 0x492);                        /* mov eax, 0x492 */
            ii(0x1015_6b06, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b07, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_6b0c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b0d, 5); mov(ecx, 0x8d);                         /* mov ecx, 0x8d */
            ii(0x1015_6b12, 5); mov(ebx, 0x36);                         /* mov ebx, 0x36 */
            ii(0x1015_6b17, 5); mov(edx, 0x466_4100);                   /* mov edx, 0x4664100 */
            ii(0x1015_6b1c, 5); mov(eax, 0x101c_9dda);                  /* mov eax, 0x101c9dda */
            ii(0x1015_6b21, 5); calld(0x1015_7aaa, 0xf84);              /* call 0x10157aaa */
            ii(0x1015_6b26, 5); calld(0x1016_4b38, 0xe00d);             /* call 0x10164b38 */
            ii(0x1015_6b2b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b2c, 5); mov(eax, StringDefinitions.LightFastVehicleWithARapidFireCannonForShootingDownEnemyPlanesMobileAntiAircraftAreGenerallyDefensiveUnitsBecauseTheyArenTAsFast); /* mov eax, 0x101b0a49 */
            ii(0x1015_6b31, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b32, 5); mov(eax, StringDefinitions.MobileAntiAircraft); /* mov eax, 0x101b0b6c */
            ii(0x1015_6b37, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b38, 5); mov(eax, StringDefinitions.MobileAntiAircraft2); /* mov eax, 0x101b0b81 */
            ii(0x1015_6b3d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b3e, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6b43, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b44, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6b46, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b47, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6b4c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b4d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6b52, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b53, 5); mov(eax, 0x741);                        /* mov eax, 0x741 */
            ii(0x1015_6b58, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b59, 5); mov(eax, 0x371);                        /* mov eax, 0x371 */
            ii(0x1015_6b5e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b5f, 5); mov(eax, 0x71d);                        /* mov eax, 0x71d */
            ii(0x1015_6b64, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b65, 5); mov(eax, 0x493);                        /* mov eax, 0x493 */
            ii(0x1015_6b6a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b6b, 5); mov(eax, 0x2e8);                        /* mov eax, 0x2e8 */
            ii(0x1015_6b70, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b71, 5); mov(ecx, 0x8e);                         /* mov ecx, 0x8e */
            ii(0x1015_6b76, 5); mov(ebx, 0x37);                         /* mov ebx, 0x37 */
            ii(0x1015_6b7b, 5); mov(edx, 0x662_4100);                   /* mov edx, 0x6624100 */
            ii(0x1015_6b80, 5); mov(eax, 0x101c_9e05);                  /* mov eax, 0x101c9e05 */
            ii(0x1015_6b85, 5); calld(0x1015_7aaa, 0xf20);              /* call 0x10157aaa */
            ii(0x1015_6b8a, 5); calld(0x1016_4b38, 0xdfa9);             /* call 0x10164b38 */
            ii(0x1015_6b8f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b90, 5); mov(eax, StringDefinitions.MinelayersAreSpecializedConstructionVehiclesWhichPlaceDetectAndRemoveMinesMinelayersConvertOnboardRawMaterialsIntoMinesTheyCanAl); /* mov eax, 0x101b0b96 */
            ii(0x1015_6b95, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b96, 5); mov(eax, StringDefinitions.MineLayers); /* mov eax, 0x101b0cca */
            ii(0x1015_6b9b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6b9c, 5); mov(eax, StringDefinitions.MineLayer);  /* mov eax, 0x101b0cd6 */
            ii(0x1015_6ba1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ba2, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6ba7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ba8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6bad, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bae, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6bb3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bb4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6bb9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bba, 5); mov(eax, 0x742);                        /* mov eax, 0x742 */
            ii(0x1015_6bbf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bc0, 5); mov(eax, 0x372);                        /* mov eax, 0x372 */
            ii(0x1015_6bc5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bc6, 5); mov(eax, 0x71e);                        /* mov eax, 0x71e */
            ii(0x1015_6bcb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bcc, 5); mov(eax, 0x494);                        /* mov eax, 0x494 */
            ii(0x1015_6bd1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bd2, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_6bd7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bd8, 5); mov(ecx, 0x8f);                         /* mov ecx, 0x8f */
            ii(0x1015_6bdd, 5); mov(ebx, 0x38);                         /* mov ebx, 0x38 */
            ii(0x1015_6be2, 5); mov(edx, 0x460_4100);                   /* mov edx, 0x4604100 */
            ii(0x1015_6be7, 5); mov(eax, 0x101c_9e30);                  /* mov eax, 0x101c9e30 */
            ii(0x1015_6bec, 5); calld(0x1015_7aaa, 0xeb9);              /* call 0x10157aaa */
            ii(0x1015_6bf1, 5); mov(eax, StringDefinitions.SurveyorsSpotMineralsUnderTheGroundToFindAGoodSpotForAMiningStationMoveTheSurveyorAroundUntilYouFindASquareWithAWhiteRawMaterial); /* mov eax, 0x101b0ce1 */
            ii(0x1015_6bf6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bf7, 5); mov(eax, StringDefinitions.LightAmphibiousVehicleWithSophisticatedSensorsForDetectingUndergroundMineralsAndEnemyMinesUnlikeMostAmphibiousUnitsSurveyorsAreJ); /* mov eax, 0x101b0da9 */
            ii(0x1015_6bfc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6bfd, 5); mov(eax, StringDefinitions.Surveyors);  /* mov eax, 0x101b0e61 */
            ii(0x1015_6c02, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c03, 5); mov(eax, StringDefinitions.Surveyor);   /* mov eax, 0x101b0e6b */
            ii(0x1015_6c08, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c09, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6c0e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c0f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6c11, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c12, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_6c17, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c18, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6c1d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c1e, 5); mov(eax, 0x743);                        /* mov eax, 0x743 */
            ii(0x1015_6c23, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c24, 5); mov(eax, 0x373);                        /* mov eax, 0x373 */
            ii(0x1015_6c29, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c2a, 5); mov(eax, 0x71f);                        /* mov eax, 0x71f */
            ii(0x1015_6c2f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c30, 5); mov(eax, 0x495);                        /* mov eax, 0x495 */
            ii(0x1015_6c35, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c36, 5); mov(eax, 0x2f2);                        /* mov eax, 0x2f2 */
            ii(0x1015_6c3b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c3c, 5); mov(ecx, 0x90);                         /* mov ecx, 0x90 */
            ii(0x1015_6c41, 5); mov(ebx, 0x39);                         /* mov ebx, 0x39 */
            ii(0x1015_6c46, 5); mov(edx, 0x460_4180);                   /* mov edx, 0x4604180 */
            ii(0x1015_6c4b, 5); mov(eax, 0x101c_9e5b);                  /* mov eax, 0x101c9e5b */
            ii(0x1015_6c50, 5); calld(0x1015_7aaa, 0xe55);              /* call 0x10157aaa */
            ii(0x1015_6c55, 5); calld(0x1016_4b38, 0xdede);             /* call 0x10164b38 */
            ii(0x1015_6c5a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c5b, 5); mov(eax, StringDefinitions.MobileRadarPlatformSlowerAndMoreExpensiveThanAScoutButWithABetterScanRangeAScannerIsAnExcellentWayToSpotTargetsForVeryLongRanged); /* mov eax, 0x101b0e74 */
            ii(0x1015_6c60, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c61, 5); mov(eax, StringDefinitions.Scanners);   /* mov eax, 0x101b0f33 */
            ii(0x1015_6c66, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c67, 5); mov(eax, StringDefinitions.Scanner);    /* mov eax, 0x101b0f3c */
            ii(0x1015_6c6c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c6d, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6c72, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c73, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6c75, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c76, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6c7b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c7c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6c81, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c82, 5); mov(eax, 0x744);                        /* mov eax, 0x744 */
            ii(0x1015_6c87, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c88, 5); mov(eax, 0x374);                        /* mov eax, 0x374 */
            ii(0x1015_6c8d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c8e, 5); mov(eax, 0x720);                        /* mov eax, 0x720 */
            ii(0x1015_6c93, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c94, 5); mov(eax, 0x496);                        /* mov eax, 0x496 */
            ii(0x1015_6c99, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6c9a, 5); mov(eax, 0x2fc);                        /* mov eax, 0x2fc */
            ii(0x1015_6c9f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ca0, 5); mov(ecx, 0x91);                         /* mov ecx, 0x91 */
            ii(0x1015_6ca5, 5); mov(ebx, 0x3a);                         /* mov ebx, 0x3a */
            ii(0x1015_6caa, 5); mov(edx, 0xc60_4100);                   /* mov edx, 0xc604100 */
            ii(0x1015_6caf, 5); mov(eax, 0x101c_9e86);                  /* mov eax, 0x101c9e86 */
            ii(0x1015_6cb4, 5); calld(0x1015_7aaa, 0xdf1);              /* call 0x10157aaa */
            ii(0x1015_6cb9, 5); calld(0x1016_4b38, 0xde7a);             /* call 0x10164b38 */
            ii(0x1015_6cbe, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cbf, 5); mov(eax, StringDefinitions.TruckForHaulingRawMaterialUsefulForResupplyingEngineersAndConstructorsAndForSupplyingCombatUnitsWithNewAmmunition); /* mov eax, 0x101b0f44 */
            ii(0x1015_6cc4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cc5, 5); mov(eax, StringDefinitions.SupplyTrucks); /* mov eax, 0x101b0fcc */
            ii(0x1015_6cca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ccb, 5); mov(eax, StringDefinitions.SupplyTruck); /* mov eax, 0x101b0fda */
            ii(0x1015_6cd0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cd1, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6cd6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cd7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6cdc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cdd, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6ce2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ce3, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6ce8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ce9, 5); mov(eax, 0x745);                        /* mov eax, 0x745 */
            ii(0x1015_6cee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cef, 5); mov(eax, 0x375);                        /* mov eax, 0x375 */
            ii(0x1015_6cf4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cf5, 5); mov(eax, 0x721);                        /* mov eax, 0x721 */
            ii(0x1015_6cfa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6cfb, 5); mov(eax, 0x497);                        /* mov eax, 0x497 */
            ii(0x1015_6d00, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d01, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_6d06, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d07, 5); mov(ecx, 0x92);                         /* mov ecx, 0x92 */
            ii(0x1015_6d0c, 5); mov(ebx, 0x3b);                         /* mov ebx, 0x3b */
            ii(0x1015_6d11, 5); mov(edx, 0x460_4100);                   /* mov edx, 0x4604100 */
            ii(0x1015_6d16, 5); mov(eax, 0x101c_9eb1);                  /* mov eax, 0x101c9eb1 */
            ii(0x1015_6d1b, 5); calld(0x1015_7aaa, 0xd8a);              /* call 0x10157aaa */
            ii(0x1015_6d20, 5); calld(0x1016_4b38, 0xde13);             /* call 0x10164b38 */
            ii(0x1015_6d25, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d26, 5); mov(eax, StringDefinitions.UnitForMovingGoldOreFromOneLocationToAnother); /* mov eax, 0x101b0fe7 */
            ii(0x1015_6d2b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d2c, 5); mov(eax, StringDefinitions.GoldTrucks); /* mov eax, 0x101b101e */
            ii(0x1015_6d31, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d32, 5); mov(eax, StringDefinitions.GoldTruck);  /* mov eax, 0x101b102a */
            ii(0x1015_6d37, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d38, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6d3d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d3e, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1015_6d43, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d44, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6d49, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d4a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6d4f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d50, 5); mov(eax, 0x746);                        /* mov eax, 0x746 */
            ii(0x1015_6d55, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d56, 5); mov(eax, 0x376);                        /* mov eax, 0x376 */
            ii(0x1015_6d5b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d5c, 5); mov(eax, 0x722);                        /* mov eax, 0x722 */
            ii(0x1015_6d61, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d62, 5); mov(eax, 0x498);                        /* mov eax, 0x498 */
            ii(0x1015_6d67, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d68, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_6d6d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d6e, 5); mov(ecx, 0x93);                         /* mov ecx, 0x93 */
            ii(0x1015_6d73, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1015_6d78, 5); mov(edx, 0x460_4100);                   /* mov edx, 0x4604100 */
            ii(0x1015_6d7d, 5); mov(eax, 0x101c_9edc);                  /* mov eax, 0x101c9edc */
            ii(0x1015_6d82, 5); calld(0x1015_7aaa, 0xd23);              /* call 0x10157aaa */
            ii(0x1015_6d87, 5); mov(eax, StringDefinitions.YouHaveAnEngineerSelectedToShowTheBuildButtonClickAgainOnTheEngineerClickOnAnyOtherUnitToSelectThatUnit); /* mov eax, 0x101b1035 */
            ii(0x1015_6d8c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d8d, 5); mov(eax, StringDefinitions.SmallConstructionVehicleForCreatingSmallBuildingsAndStationaryWeapons); /* mov eax, 0x101b10ba */
            ii(0x1015_6d92, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d93, 5); mov(eax, StringDefinitions.Engineers);  /* mov eax, 0x101b110a */
            ii(0x1015_6d98, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d99, 5); mov(eax, StringDefinitions.Engineer);   /* mov eax, 0x101b1114 */
            ii(0x1015_6d9e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6d9f, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6da4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6da5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6daa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6dab, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_6db0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6db1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6db6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6db7, 5); mov(eax, 0x747);                        /* mov eax, 0x747 */
            ii(0x1015_6dbc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6dbd, 5); mov(eax, 0x377);                        /* mov eax, 0x377 */
            ii(0x1015_6dc2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6dc3, 5); mov(eax, 0x723);                        /* mov eax, 0x723 */
            ii(0x1015_6dc8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6dc9, 5); mov(eax, 0x499);                        /* mov eax, 0x499 */
            ii(0x1015_6dce, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6dcf, 5); mov(eax, 0x2f2);                        /* mov eax, 0x2f2 */
            ii(0x1015_6dd4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6dd5, 5); mov(ecx, 0x94);                         /* mov ecx, 0x94 */
            ii(0x1015_6dda, 5); mov(ebx, 0x3d);                         /* mov ebx, 0x3d */
            ii(0x1015_6ddf, 5); mov(edx, 0x468_4180);                   /* mov edx, 0x4684180 */
            ii(0x1015_6de4, 5); mov(eax, 0x101c_9f07);                  /* mov eax, 0x101c9f07 */
            ii(0x1015_6de9, 5); calld(0x1015_7aaa, 0xcbc);              /* call 0x10157aaa */
            ii(0x1015_6dee, 5); calld(0x1016_4b38, 0xdd45);             /* call 0x10164b38 */
            ii(0x1015_6df3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6df4, 5); mov(eax, StringDefinitions.VehicleForClearingRubbleAndDemolishingBuildingsBulldozersCanScavengeMaterialFromDebris); /* mov eax, 0x101b111d */
            ii(0x1015_6df9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6dfa, 5); mov(eax, StringDefinitions.Bulldozers); /* mov eax, 0x101b1182 */
            ii(0x1015_6dff, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e00, 5); mov(eax, StringDefinitions.Bulldozer);  /* mov eax, 0x101b118d */
            ii(0x1015_6e05, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e06, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6e0b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e0c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6e11, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e12, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6e17, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e18, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6e1d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e1e, 5); mov(eax, 0x748);                        /* mov eax, 0x748 */
            ii(0x1015_6e23, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e24, 5); mov(eax, 0x378);                        /* mov eax, 0x378 */
            ii(0x1015_6e29, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e2a, 5); mov(eax, 0x724);                        /* mov eax, 0x724 */
            ii(0x1015_6e2f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e30, 5); mov(eax, 0x49a);                        /* mov eax, 0x49a */
            ii(0x1015_6e35, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e36, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_6e3b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e3c, 5); mov(ecx, 0x95);                         /* mov ecx, 0x95 */
            ii(0x1015_6e41, 5); mov(ebx, 0x3e);                         /* mov ebx, 0x3e */
            ii(0x1015_6e46, 5); mov(edx, 0x460_4100);                   /* mov edx, 0x4604100 */
            ii(0x1015_6e4b, 5); mov(eax, 0x101c_9f32);                  /* mov eax, 0x101c9f32 */
            ii(0x1015_6e50, 5); calld(0x1015_7aaa, 0xc55);              /* call 0x10157aaa */
            ii(0x1015_6e55, 5); calld(0x1016_4b38, 0xdcde);             /* call 0x10164b38 */
            ii(0x1015_6e5a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e5b, 5); mov(eax, StringDefinitions.LightVehicleWhichCanRapidlyRepairGroundUnitsAndBuildingsRepairsRequireMaterialsTheMostExtensiveTheDamageTheMoreMaterialsTheRepai); /* mov eax, 0x101b1197 */
            ii(0x1015_6e60, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e61, 5); mov(eax, StringDefinitions.RepairUnits); /* mov eax, 0x101b127b */
            ii(0x1015_6e66, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e67, 5); mov(eax, StringDefinitions.RepairUnit); /* mov eax, 0x101b1288 */
            ii(0x1015_6e6c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e6d, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6e72, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e73, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6e78, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e79, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6e7e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e7f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6e84, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e85, 5); mov(eax, 0x749);                        /* mov eax, 0x749 */
            ii(0x1015_6e8a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e8b, 5); mov(eax, 0x379);                        /* mov eax, 0x379 */
            ii(0x1015_6e90, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e91, 5); mov(eax, 0x725);                        /* mov eax, 0x725 */
            ii(0x1015_6e96, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e97, 5); mov(eax, 0x49b);                        /* mov eax, 0x49b */
            ii(0x1015_6e9c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6e9d, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_6ea2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ea3, 5); mov(ecx, 0x96);                         /* mov ecx, 0x96 */
            ii(0x1015_6ea8, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1015_6ead, 5); mov(edx, 0x460_4100);                   /* mov edx, 0x4604100 */
            ii(0x1015_6eb2, 5); mov(eax, 0x101c_9f5d);                  /* mov eax, 0x101c9f5d */
            ii(0x1015_6eb7, 5); calld(0x1015_7aaa, 0xbee);              /* call 0x10157aaa */
            ii(0x1015_6ebc, 5); calld(0x1016_4b38, 0xdc77);             /* call 0x10164b38 */
            ii(0x1015_6ec1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ec2, 5); mov(eax, StringDefinitions.TruckForMovingFuel); /* mov eax, 0x101b1294 */
            ii(0x1015_6ec7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ec8, 5); mov(eax, StringDefinitions.FuelTrucks); /* mov eax, 0x101b12ab */
            ii(0x1015_6ecd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ece, 5); mov(eax, StringDefinitions.FuelTruck);  /* mov eax, 0x101b12b7 */
            ii(0x1015_6ed3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ed4, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6ed9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6eda, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_6edf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ee0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_6ee5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ee6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6eeb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6eec, 5); mov(eax, 0x74a);                        /* mov eax, 0x74a */
            ii(0x1015_6ef1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ef2, 5); mov(eax, 0x37a);                        /* mov eax, 0x37a */
            ii(0x1015_6ef7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ef8, 5); mov(eax, 0x726);                        /* mov eax, 0x726 */
            ii(0x1015_6efd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6efe, 5); mov(eax, 0x49c);                        /* mov eax, 0x49c */
            ii(0x1015_6f03, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f04, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_6f09, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f0a, 5); mov(ecx, 0x97);                         /* mov ecx, 0x97 */
            ii(0x1015_6f0f, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x1015_6f14, 5); mov(edx, 0x460_4100);                   /* mov edx, 0x4604100 */
            ii(0x1015_6f19, 5); mov(eax, 0x101c_9f88);                  /* mov eax, 0x101c9f88 */
            ii(0x1015_6f1e, 5); calld(0x1015_7aaa, 0xb87);              /* call 0x10157aaa */
            ii(0x1015_6f23, 5); calld(0x1016_4b38, 0xdc10);             /* call 0x10164b38 */
            ii(0x1015_6f28, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f29, 5); mov(eax, StringDefinitions.FastArmoredToTransportInfantryAndInfiltratorsTheApcCanMoveSlowlyUnderwaterAsWellAsOnLandOnlyEnemyCorvettesCanDetectAnApcMovingUn); /* mov eax, 0x101b12c2 */
            ii(0x1015_6f2e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f2f, 5); mov(eax, StringDefinitions.PersonnelCarriers); /* mov eax, 0x101b136a */
            ii(0x1015_6f34, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f35, 5); mov(eax, StringDefinitions.PersonnelCarrier); /* mov eax, 0x101b137d */
            ii(0x1015_6f3a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f3b, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_6f40, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f41, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1015_6f46, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f47, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1015_6f4c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f4d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6f52, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f53, 5); mov(eax, 0x74b);                        /* mov eax, 0x74b */
            ii(0x1015_6f58, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f59, 5); mov(eax, 0x37b);                        /* mov eax, 0x37b */
            ii(0x1015_6f5e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f5f, 5); mov(eax, 0x727);                        /* mov eax, 0x727 */
            ii(0x1015_6f64, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f65, 5); mov(eax, 0x49d);                        /* mov eax, 0x49d */
            ii(0x1015_6f6a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f6b, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_6f70, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f71, 5); mov(ecx, 0x98);                         /* mov ecx, 0x98 */
            ii(0x1015_6f76, 5); mov(ebx, 0x41);                         /* mov ebx, 0x41 */
            ii(0x1015_6f7b, 5); mov(edx, 0x460_4180);                   /* mov edx, 0x4604180 */
            ii(0x1015_6f80, 5); mov(eax, 0x101c_9fb3);                  /* mov eax, 0x101c9fb3 */
            ii(0x1015_6f85, 5); calld(0x1015_7aaa, 0xb20);              /* call 0x10157aaa */
            ii(0x1015_6f8a, 5); calld(0x1016_4b38, 0xdba9);             /* call 0x10164b38 */
            ii(0x1015_6f8f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f90, 5); mov(eax, StringDefinitions.CommandoTrainedInTheArtsOfStealthAndElectronicWarfareInfiltratorsCanDisableOrCaptureEnemyUnitsInfiltratorsAreNormallyInvisibleUn); /* mov eax, 0x101b138f */
            ii(0x1015_6f95, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f96, 5); mov(eax, StringDefinitions.Infiltrators); /* mov eax, 0x101b148c */
            ii(0x1015_6f9b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6f9c, 5); mov(eax, StringDefinitions.Infiltrator); /* mov eax, 0x101b1499 */
            ii(0x1015_6fa1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fa2, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_6fa7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fa8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_6faa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fab, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1015_6fb0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fb1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_6fb6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fb7, 5); mov(eax, 0x74c);                        /* mov eax, 0x74c */
            ii(0x1015_6fbc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fbd, 5); mov(eax, 0x37c);                        /* mov eax, 0x37c */
            ii(0x1015_6fc2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fc3, 5); mov(eax, 0x728);                        /* mov eax, 0x728 */
            ii(0x1015_6fc8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fc9, 5); mov(eax, 0x49e);                        /* mov eax, 0x49e */
            ii(0x1015_6fce, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fcf, 5); mov(eax, 0x2f5);                        /* mov eax, 0x2f5 */
            ii(0x1015_6fd4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6fd5, 5); mov(ecx, 0x99);                         /* mov ecx, 0x99 */
            ii(0x1015_6fda, 5); mov(ebx, 0x42);                         /* mov ebx, 0x42 */
            ii(0x1015_6fdf, 5); mov(edx, 0x442_4100);                   /* mov edx, 0x4424100 */
            ii(0x1015_6fe4, 5); mov(eax, 0x101c_9fde);                  /* mov eax, 0x101c9fde */
            ii(0x1015_6fe9, 5); calld(0x1015_7aaa, 0xabc);              /* call 0x10157aaa */
            ii(0x1015_6fee, 5); calld(0x1016_4b38, 0xdb45);             /* call 0x10164b38 */
            ii(0x1015_6ff3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ff4, 5); mov(eax, StringDefinitions.HumanSoldiersEquippedWithLightAntiTankShoulderWeaponsInfantryCanSpotEnemyInflitrators); /* mov eax, 0x101b14a5 */
            ii(0x1015_6ff9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_6ffa, 5); mov(eax, StringDefinitions.Infantry);   /* mov eax, 0x101b150b */
            ii(0x1015_6fff, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7000, 5); mov(eax, StringDefinitions.Infantry2);  /* mov eax, 0x101b1514 */
            ii(0x1015_7005, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7006, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_700b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_700c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_700e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_700f, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1015_7014, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7015, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_701a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_701b, 5); mov(eax, 0x74d);                        /* mov eax, 0x74d */
            ii(0x1015_7020, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7021, 5); mov(eax, 0x37d);                        /* mov eax, 0x37d */
            ii(0x1015_7026, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7027, 5); mov(eax, 0x729);                        /* mov eax, 0x729 */
            ii(0x1015_702c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_702d, 5); mov(eax, 0x49f);                        /* mov eax, 0x49f */
            ii(0x1015_7032, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7033, 5); mov(eax, 0x2f6);                        /* mov eax, 0x2f6 */
            ii(0x1015_7038, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7039, 5); mov(ecx, 0x9a);                         /* mov ecx, 0x9a */
            ii(0x1015_703e, 5); mov(ebx, 0x43);                         /* mov ebx, 0x43 */
            ii(0x1015_7043, 5); mov(edx, 0x442_4100);                   /* mov edx, 0x4424100 */
            ii(0x1015_7048, 5); mov(eax, 0x101c_a009);                  /* mov eax, 0x101ca009 */
            ii(0x1015_704d, 5); calld(0x1015_7aaa, 0xa58);              /* call 0x10157aaa */
            ii(0x1015_7052, 5); calld(0x1016_4b38, 0xdae1);             /* call 0x10164b38 */
            ii(0x1015_7057, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7058, 5); mov(eax, StringDefinitions.HighSpeedBoatWithGoodRadarAndRapidFireAntiAircraftCannonEscortsAreTheEyesOfAFleetAndAFleetSProtectionFromPlanes); /* mov eax, 0x101b151d */
            ii(0x1015_705d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_705e, 5); mov(eax, StringDefinitions.Escorts);    /* mov eax, 0x101b15aa */
            ii(0x1015_7063, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7064, 5); mov(eax, StringDefinitions.Escort);     /* mov eax, 0x101b15b2 */
            ii(0x1015_7069, 1); pushd(eax);                             /* push eax */
            ii(0x1015_706a, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_706f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7070, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7072, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7073, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_7078, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7079, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_707e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_707f, 5); mov(eax, 0x74e);                        /* mov eax, 0x74e */
            ii(0x1015_7084, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7085, 5); mov(eax, 0x37e);                        /* mov eax, 0x37e */
            ii(0x1015_708a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_708b, 5); mov(eax, 0x72a);                        /* mov eax, 0x72a */
            ii(0x1015_7090, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7091, 5); mov(eax, 0x4a0);                        /* mov eax, 0x4a0 */
            ii(0x1015_7096, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7097, 5); mov(eax, 0x2fa);                        /* mov eax, 0x2fa */
            ii(0x1015_709c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_709d, 5); mov(ecx, 0x9b);                         /* mov ecx, 0x9b */
            ii(0x1015_70a2, 5); mov(ebx, 0x44);                         /* mov ebx, 0x44 */
            ii(0x1015_70a7, 5); mov(edx, 0x662_4080);                   /* mov edx, 0x6624080 */
            ii(0x1015_70ac, 5); mov(eax, 0x101c_a034);                  /* mov eax, 0x101ca034 */
            ii(0x1015_70b1, 5); calld(0x1015_7aaa, 0x9f4);              /* call 0x10157aaa */
            ii(0x1015_70b6, 5); calld(0x1016_4b38, 0xda7d);             /* call 0x10164b38 */
            ii(0x1015_70bb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70bc, 5); mov(eax, StringDefinitions.HighSpeedBoatWithTorpedoTubesAndSonarCorvettesCanAttackAnySeaUnitButTheirRealStrengthIsTheirAbilityToSpotAndAttackSubmarines); /* mov eax, 0x101b15b9 */
            ii(0x1015_70c1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70c2, 5); mov(eax, StringDefinitions.Corvettes);  /* mov eax, 0x101b1653 */
            ii(0x1015_70c7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70c8, 5); mov(eax, StringDefinitions.Corvette);   /* mov eax, 0x101b165d */
            ii(0x1015_70cd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70ce, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_70d3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70d4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_70d6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70d7, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_70dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70dd, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_70e2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70e3, 5); mov(eax, 0x74f);                        /* mov eax, 0x74f */
            ii(0x1015_70e8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70e9, 5); mov(eax, 0x37f);                        /* mov eax, 0x37f */
            ii(0x1015_70ee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70ef, 5); mov(eax, 0x72b);                        /* mov eax, 0x72b */
            ii(0x1015_70f4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70f5, 5); mov(eax, 0x4a1);                        /* mov eax, 0x4a1 */
            ii(0x1015_70fa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_70fb, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_7100, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7101, 5); mov(ecx, 0x9c);                         /* mov ecx, 0x9c */
            ii(0x1015_7106, 5); mov(ebx, 0x45);                         /* mov ebx, 0x45 */
            ii(0x1015_710b, 5); mov(edx, 0x466_4080);                   /* mov edx, 0x4664080 */
            ii(0x1015_7110, 5); mov(eax, 0x101c_a05f);                  /* mov eax, 0x101ca05f */
            ii(0x1015_7115, 5); calld(0x1015_7aaa, 0x990);              /* call 0x10157aaa */
            ii(0x1015_711a, 5); calld(0x1016_4b38, 0xda19);             /* call 0x10164b38 */
            ii(0x1015_711f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7120, 5); mov(eax, StringDefinitions.HeavilyArmoredShipWithAHighCaliberMediumRangeCannonExcellentAtDestroyingOtherShipsAndBombardingShoreTargets); /* mov eax, 0x101b1666 */
            ii(0x1015_7125, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7126, 5); mov(eax, StringDefinitions.Gunboat);    /* mov eax, 0x101b16e8 */
            ii(0x1015_712b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_712c, 5); mov(eax, StringDefinitions.Gunboat2);   /* mov eax, 0x101b16f0 */
            ii(0x1015_7131, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7132, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_7137, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7138, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_713a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_713b, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_7140, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7141, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7146, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7147, 5); mov(eax, 0x750);                        /* mov eax, 0x750 */
            ii(0x1015_714c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_714d, 5); mov(eax, 0x380);                        /* mov eax, 0x380 */
            ii(0x1015_7152, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7153, 5); mov(eax, 0x72c);                        /* mov eax, 0x72c */
            ii(0x1015_7158, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7159, 5); mov(eax, 0x4a2);                        /* mov eax, 0x4a2 */
            ii(0x1015_715e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_715f, 5); mov(eax, 0x2f3);                        /* mov eax, 0x2f3 */
            ii(0x1015_7164, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7165, 5); mov(ecx, 0x9d);                         /* mov ecx, 0x9d */
            ii(0x1015_716a, 5); mov(ebx, 0x46);                         /* mov ebx, 0x46 */
            ii(0x1015_716f, 5); mov(edx, 0x662_4080);                   /* mov edx, 0x6624080 */
            ii(0x1015_7174, 5); mov(eax, 0x101c_a08a);                  /* mov eax, 0x101ca08a */
            ii(0x1015_7179, 5); calld(0x1015_7aaa, 0x92c);              /* call 0x10157aaa */
            ii(0x1015_717e, 5); calld(0x1016_4b38, 0xd9b5);             /* call 0x10164b38 */
            ii(0x1015_7183, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7184, 5); mov(eax, StringDefinitions.LurkingBeneathTheSurfaceSubmarinesMustSneakCloseToTheEnemyToFireTheirPowerfulTorpedoesSubmarinesDoNotCarryActiveSonarWhichMightR); /* mov eax, 0x101b16f8 */
            ii(0x1015_7189, 1); pushd(eax);                             /* push eax */
            ii(0x1015_718a, 5); mov(eax, StringDefinitions.Submarines); /* mov eax, 0x101b1828 */
            ii(0x1015_718f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7190, 5); mov(eax, StringDefinitions.Submarine);  /* mov eax, 0x101b1833 */
            ii(0x1015_7195, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7196, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_719b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_719c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_719e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_719f, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_71a4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71a5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_71aa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71ab, 5); mov(eax, 0x751);                        /* mov eax, 0x751 */
            ii(0x1015_71b0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71b1, 5); mov(eax, 0x381);                        /* mov eax, 0x381 */
            ii(0x1015_71b6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71b7, 5); mov(eax, 0x72d);                        /* mov eax, 0x72d */
            ii(0x1015_71bc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71bd, 5); mov(eax, 0x4a3);                        /* mov eax, 0x4a3 */
            ii(0x1015_71c2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71c3, 5); mov(eax, 0x2fd);                        /* mov eax, 0x2fd */
            ii(0x1015_71c8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71c9, 5); mov(ecx, 0x9e);                         /* mov ecx, 0x9e */
            ii(0x1015_71ce, 5); mov(ebx, 0x47);                         /* mov ebx, 0x47 */
            ii(0x1015_71d3, 5); mov(edx, 0x464_4080);                   /* mov edx, 0x4644080 */
            ii(0x1015_71d8, 5); mov(eax, 0x101c_a0b5);                  /* mov eax, 0x101ca0b5 */
            ii(0x1015_71dd, 5); calld(0x1015_7aaa, 0x8c8);              /* call 0x10157aaa */
            ii(0x1015_71e2, 5); calld(0x1016_4b38, 0xd951);             /* call 0x10164b38 */
            ii(0x1015_71e7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71e8, 5); mov(eax, StringDefinitions.HeavilyArmoredShipWithSpaceToCarryUpToSixLandUnitsSeaTransportsAreMuchSlowerThanAirTransportsButAlsoMuchMoreLikelyToSurviveAnEne); /* mov eax, 0x101b183d */
            ii(0x1015_71ed, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71ee, 5); mov(eax, StringDefinitions.SeaTransports); /* mov eax, 0x101b18e7 */
            ii(0x1015_71f3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71f4, 5); mov(eax, StringDefinitions.SeaTransport); /* mov eax, 0x101b18f6 */
            ii(0x1015_71f9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_71fa, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_71ff, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7200, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1015_7205, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7206, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1015_720b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_720c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7211, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7212, 5); mov(eax, 0x752);                        /* mov eax, 0x752 */
            ii(0x1015_7217, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7218, 5); mov(eax, 0x382);                        /* mov eax, 0x382 */
            ii(0x1015_721d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_721e, 5); mov(eax, 0x72e);                        /* mov eax, 0x72e */
            ii(0x1015_7223, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7224, 5); mov(eax, 0x4a4);                        /* mov eax, 0x4a4 */
            ii(0x1015_7229, 1); pushd(eax);                             /* push eax */
            ii(0x1015_722a, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_722f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7230, 5); mov(ecx, 0x9f);                         /* mov ecx, 0x9f */
            ii(0x1015_7235, 5); mov(ebx, 0x48);                         /* mov ebx, 0x48 */
            ii(0x1015_723a, 5); mov(edx, 0x460_4080);                   /* mov edx, 0x4604080 */
            ii(0x1015_723f, 5); mov(eax, 0x101c_a0e0);                  /* mov eax, 0x101ca0e0 */
            ii(0x1015_7244, 5); calld(0x1015_7aaa, 0x861);              /* call 0x10157aaa */
            ii(0x1015_7249, 5); calld(0x1016_4b38, 0xd8ea);             /* call 0x10164b38 */
            ii(0x1015_724e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_724f, 5); mov(eax, StringDefinitions.ShipMountedMissileLauncherExcellentRangeHighAttackStrengthAndMediumArmorMakesThisAPowerfulUnit); /* mov eax, 0x101b1904 */
            ii(0x1015_7254, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7255, 5); mov(eax, StringDefinitions.MissileCruisers); /* mov eax, 0x101b1978 */
            ii(0x1015_725a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_725b, 5); mov(eax, StringDefinitions.MissileCruiser); /* mov eax, 0x101b1989 */
            ii(0x1015_7260, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7261, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_7266, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7267, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7269, 1); pushd(eax);                             /* push eax */
            ii(0x1015_726a, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_726f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7270, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7275, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7276, 5); mov(eax, 0x753);                        /* mov eax, 0x753 */
            ii(0x1015_727b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_727c, 5); mov(eax, 0x383);                        /* mov eax, 0x383 */
            ii(0x1015_7281, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7282, 5); mov(eax, 0x72f);                        /* mov eax, 0x72f */
            ii(0x1015_7287, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7288, 5); mov(eax, 0x4a5);                        /* mov eax, 0x4a5 */
            ii(0x1015_728d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_728e, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_7293, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7294, 5); mov(ecx, 0xa0);                         /* mov ecx, 0xa0 */
            ii(0x1015_7299, 5); mov(ebx, 0x49);                         /* mov ebx, 0x49 */
            ii(0x1015_729e, 5); mov(edx, 0x466_4080);                   /* mov edx, 0x4664080 */
            ii(0x1015_72a3, 5); mov(eax, 0x101c_a10b);                  /* mov eax, 0x101ca10b */
            ii(0x1015_72a8, 5); calld(0x1015_7aaa, 0x7fd);              /* call 0x10157aaa */
            ii(0x1015_72ad, 5); calld(0x1016_4b38, 0xd886);             /* call 0x10164b38 */
            ii(0x1015_72b2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72b3, 5); mov(eax, StringDefinitions.SeaborneVersionOfTheMinelayerLikeItsLandBasedCounterpartTheSeaMinelayerCanManufactureMinesDetectThemAndConvertThemBackIntoRawMat); /* mov eax, 0x101b1999 */
            ii(0x1015_72b8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72b9, 5); mov(eax, StringDefinitions.SeaMineLayers); /* mov eax, 0x101b1a3d */
            ii(0x1015_72be, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72bf, 5); mov(eax, StringDefinitions.SeaMineLayer); /* mov eax, 0x101b1a4d */
            ii(0x1015_72c4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72c5, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_72ca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72cb, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_72d0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72d1, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_72d6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72d7, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_72dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72dd, 5); mov(eax, 0x754);                        /* mov eax, 0x754 */
            ii(0x1015_72e2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72e3, 5); mov(eax, 0x384);                        /* mov eax, 0x384 */
            ii(0x1015_72e8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72e9, 5); mov(eax, 0x730);                        /* mov eax, 0x730 */
            ii(0x1015_72ee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72ef, 5); mov(eax, 0x4a6);                        /* mov eax, 0x4a6 */
            ii(0x1015_72f4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72f5, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_72fa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_72fb, 5); mov(ecx, 0xa1);                         /* mov ecx, 0xa1 */
            ii(0x1015_7300, 5); mov(ebx, 0x4a);                         /* mov ebx, 0x4a */
            ii(0x1015_7305, 5); mov(edx, 0x460_4080);                   /* mov edx, 0x4604080 */
            ii(0x1015_730a, 5); mov(eax, 0x101c_a136);                  /* mov eax, 0x101ca136 */
            ii(0x1015_730f, 5); calld(0x1015_7aaa, 0x796);              /* call 0x10157aaa */
            ii(0x1015_7314, 5); calld(0x1016_4b38, 0xd81f);             /* call 0x10164b38 */
            ii(0x1015_7319, 1); pushd(eax);                             /* push eax */
            ii(0x1015_731a, 5); mov(eax, StringDefinitions.ShipsForHaulingRawMaterialUsefulForResupplyingEngineersAndSeaCombatUnitsWithNewAmmunition); /* mov eax, 0x101b1a5c */
            ii(0x1015_731f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7320, 5); mov(eax, StringDefinitions.CargoShip);  /* mov eax, 0x101b1ac8 */
            ii(0x1015_7325, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7326, 5); mov(eax, StringDefinitions.CargoShip2); /* mov eax, 0x101b1ad3 */
            ii(0x1015_732b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_732c, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_7331, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7332, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_7337, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7338, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1015_733d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_733e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7343, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7344, 5); mov(eax, 0x755);                        /* mov eax, 0x755 */
            ii(0x1015_7349, 1); pushd(eax);                             /* push eax */
            ii(0x1015_734a, 5); mov(eax, 0x385);                        /* mov eax, 0x385 */
            ii(0x1015_734f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7350, 5); mov(eax, 0x731);                        /* mov eax, 0x731 */
            ii(0x1015_7355, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7356, 5); mov(eax, 0x4a7);                        /* mov eax, 0x4a7 */
            ii(0x1015_735b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_735c, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_7361, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7362, 5); mov(ecx, 0xa2);                         /* mov ecx, 0xa2 */
            ii(0x1015_7367, 5); mov(ebx, 0x4b);                         /* mov ebx, 0x4b */
            ii(0x1015_736c, 5); mov(edx, 0x460_4080);                   /* mov edx, 0x4604080 */
            ii(0x1015_7371, 5); mov(eax, 0x101c_a161);                  /* mov eax, 0x101ca161 */
            ii(0x1015_7376, 5); calld(0x1015_7aaa, 0x72f);              /* call 0x10157aaa */
            ii(0x1015_737b, 5); calld(0x1016_4b38, 0xd7b8);             /* call 0x10164b38 */
            ii(0x1015_7380, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7381, 5); mov(eax, StringDefinitions.FastButFragileAircraftCarryingALimitedNumberOfAirToAirMissilesFightersAreTheBestWayToDriveEnemyPlanesOutOfAnAreaAndToDefendAMovi); /* mov eax, 0x101b1ade */
            ii(0x1015_7386, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7387, 5); mov(eax, StringDefinitions.Fighters);   /* mov eax, 0x101b1bd4 */
            ii(0x1015_738c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_738d, 5); mov(eax, StringDefinitions.Fighter);    /* mov eax, 0x101b1bdd */
            ii(0x1015_7392, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7393, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_7398, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7399, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_739b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_739c, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1015_73a1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73a2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_73a7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73a8, 5); mov(eax, 0x756);                        /* mov eax, 0x756 */
            ii(0x1015_73ad, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73ae, 5); mov(eax, 0x386);                        /* mov eax, 0x386 */
            ii(0x1015_73b3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73b4, 5); mov(eax, 0x732);                        /* mov eax, 0x732 */
            ii(0x1015_73b9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73ba, 5); mov(eax, 0x4a8);                        /* mov eax, 0x4a8 */
            ii(0x1015_73bf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73c0, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_73c5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73c6, 5); mov(ecx, 0xa3);                         /* mov ecx, 0xa3 */
            ii(0x1015_73cb, 5); mov(ebx, 0x4c);                         /* mov ebx, 0x4c */
            ii(0x1015_73d0, 5); mov(edx, 0x466_4040);                   /* mov edx, 0x4664040 */
            ii(0x1015_73d5, 5); mov(eax, 0x101c_a18c);                  /* mov eax, 0x101ca18c */
            ii(0x1015_73da, 5); calld(0x1015_7aaa, 0x6cb);              /* call 0x10157aaa */
            ii(0x1015_73df, 5); calld(0x1016_4b38, 0xd754);             /* call 0x10164b38 */
            ii(0x1015_73e4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73e5, 5); mov(eax, StringDefinitions.AHeavierPlaneCarryingAFullLoadOfAirToGroundMissilesGroundAttackPlanesAreExpensiveButTheAdvantagesAreWorthTheCostTheirGreatSpeedL); /* mov eax, 0x101b1be5 */
            ii(0x1015_73ea, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73eb, 5); mov(eax, StringDefinitions.GroundAttackPlanes); /* mov eax, 0x101b1cfb */
            ii(0x1015_73f0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73f1, 5); mov(eax, StringDefinitions.GroundAttackPlane); /* mov eax, 0x101b1d10 */
            ii(0x1015_73f6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73f7, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_73fc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_73fd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_73ff, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7400, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1015_7405, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7406, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_740b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_740c, 5); mov(eax, 0x757);                        /* mov eax, 0x757 */
            ii(0x1015_7411, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7412, 5); mov(eax, 0x387);                        /* mov eax, 0x387 */
            ii(0x1015_7417, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7418, 5); mov(eax, 0x733);                        /* mov eax, 0x733 */
            ii(0x1015_741d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_741e, 5); mov(eax, 0x4a9);                        /* mov eax, 0x4a9 */
            ii(0x1015_7423, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7424, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_7429, 1); pushd(eax);                             /* push eax */
            ii(0x1015_742a, 5); mov(ecx, 0xa4);                         /* mov ecx, 0xa4 */
            ii(0x1015_742f, 5); mov(ebx, 0x4d);                         /* mov ebx, 0x4d */
            ii(0x1015_7434, 5); mov(edx, 0x466_4040);                   /* mov edx, 0x4664040 */
            ii(0x1015_7439, 5); mov(eax, 0x101c_a1b7);                  /* mov eax, 0x101ca1b7 */
            ii(0x1015_743e, 5); calld(0x1015_7aaa, 0x667);              /* call 0x10157aaa */
            ii(0x1015_7443, 5); calld(0x1016_4b38, 0xd6f0);             /* call 0x10164b38 */
            ii(0x1015_7448, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7449, 5); mov(eax, StringDefinitions.HeavyAircraftCapableOfHoldingUpToThreeGroundUnits); /* mov eax, 0x101b1d24 */
            ii(0x1015_744e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_744f, 5); mov(eax, StringDefinitions.AirTransports); /* mov eax, 0x101b1d60 */
            ii(0x1015_7454, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7455, 5); mov(eax, StringDefinitions.AirTransport); /* mov eax, 0x101b1d6f */
            ii(0x1015_745a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_745b, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_7460, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7461, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1015_7466, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7467, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1015_746c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_746d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7472, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7473, 5); mov(eax, 0x758);                        /* mov eax, 0x758 */
            ii(0x1015_7478, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7479, 5); mov(eax, 0x388);                        /* mov eax, 0x388 */
            ii(0x1015_747e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_747f, 5); mov(eax, 0x734);                        /* mov eax, 0x734 */
            ii(0x1015_7484, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7485, 5); mov(eax, 0x4aa);                        /* mov eax, 0x4aa */
            ii(0x1015_748a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_748b, 5); mov(eax, 0x2e1);                        /* mov eax, 0x2e1 */
            ii(0x1015_7490, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7491, 5); mov(ecx, 0xa5);                         /* mov ecx, 0xa5 */
            ii(0x1015_7496, 5); mov(ebx, 0x4e);                         /* mov ebx, 0x4e */
            ii(0x1015_749b, 5); mov(edx, 0x460_4040);                   /* mov edx, 0x4604040 */
            ii(0x1015_74a0, 5); mov(eax, 0x101c_a1e2);                  /* mov eax, 0x101ca1e2 */
            ii(0x1015_74a5, 5); calld(0x1015_7aaa, 0x600);              /* call 0x10157aaa */
            ii(0x1015_74aa, 5); calld(0x1016_4b38, 0xd689);             /* call 0x10164b38 */
            ii(0x1015_74af, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74b0, 5); mov(eax, StringDefinitions.AirborneWarningAndControlPlaneBasicallyAFlyingRadarDishAnAwacIsEssentialToSpotEnemyAntiAircraftBeforeYourPlanesFlyIntoFiringRang); /* mov eax, 0x101b1d7d */
            ii(0x1015_74b5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74b6, 5); mov(eax, StringDefinitions.Awacs);      /* mov eax, 0x101b1e1c */
            ii(0x1015_74bb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74bc, 5); mov(eax, StringDefinitions.Awac);       /* mov eax, 0x101b1e22 */
            ii(0x1015_74c1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74c2, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_74c7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74c8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_74ca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74cb, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1015_74d0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74d1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_74d6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74d7, 5); mov(eax, 0x759);                        /* mov eax, 0x759 */
            ii(0x1015_74dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74dd, 5); mov(eax, 0x389);                        /* mov eax, 0x389 */
            ii(0x1015_74e2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74e3, 5); mov(eax, 0x735);                        /* mov eax, 0x735 */
            ii(0x1015_74e8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74e9, 5); mov(eax, 0x4ab);                        /* mov eax, 0x4ab */
            ii(0x1015_74ee, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74ef, 5); mov(eax, 0x2f1);                        /* mov eax, 0x2f1 */
            ii(0x1015_74f4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_74f5, 5); mov(ecx, 0xa6);                         /* mov ecx, 0xa6 */
            ii(0x1015_74fa, 5); mov(ebx, 0x4f);                         /* mov ebx, 0x4f */
            ii(0x1015_74ff, 5); mov(edx, 0xc60_4040);                   /* mov edx, 0xc604040 */
            ii(0x1015_7504, 5); mov(eax, 0x101c_a20d);                  /* mov eax, 0x101ca20d */
            ii(0x1015_7509, 5); calld(0x1015_7aaa, 0x59c);              /* call 0x10157aaa */
            ii(0x1015_750e, 5); calld(0x1016_4b38, 0xd625);             /* call 0x10164b38 */
            ii(0x1015_7513, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7514, 5); mov(eax, StringDefinitions.HeavilyArmoredAndArmedWarshipOfAlienDesignLikeTheHumanGunboatTheAlienGunboatExcelsAtDestroyingOtherShipsAndLandTargetsNearTheSho); /* mov eax, 0x101b1e27 */
            ii(0x1015_7519, 1); pushd(eax);                             /* push eax */
            ii(0x1015_751a, 5); mov(eax, StringDefinitions.AlienGunboats); /* mov eax, 0x101b1f18 */
            ii(0x1015_751f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7520, 5); mov(eax, StringDefinitions.AlienGunboat); /* mov eax, 0x101b1f27 */
            ii(0x1015_7525, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7526, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_752b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_752c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_752e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_752f, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_7534, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7535, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_753a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_753b, 5); mov(eax, 0x75a);                        /* mov eax, 0x75a */
            ii(0x1015_7540, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7541, 5); mov(eax, 0x38a);                        /* mov eax, 0x38a */
            ii(0x1015_7546, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7547, 5); mov(eax, 0x736);                        /* mov eax, 0x736 */
            ii(0x1015_754c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_754d, 5); mov(eax, 0x4ac);                        /* mov eax, 0x4ac */
            ii(0x1015_7552, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7553, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_7558, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7559, 5); mov(ecx, 0xa7);                         /* mov ecx, 0xa7 */
            ii(0x1015_755e, 5); mov(ebx, 0x50);                         /* mov ebx, 0x50 */
            ii(0x1015_7563, 5); mov(edx, 0x1466_0080);                  /* mov edx, 0x14660080 */
            ii(0x1015_7568, 5); mov(eax, 0x101c_a238);                  /* mov eax, 0x101ca238 */
            ii(0x1015_756d, 5); calld(0x1015_7aaa, 0x538);              /* call 0x10157aaa */
            ii(0x1015_7572, 5); calld(0x1016_4b38, 0xd5c1);             /* call 0x10164b38 */
            ii(0x1015_7577, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7578, 5); mov(eax, StringDefinitions.HeavilyArmoredTankOfAlienDesignAlienTanksAreBestUsedAtTheFrontOfAnAttackToSoakUpEnemyFireAllAlienUnitsRepairThemselvesAndImprove); /* mov eax, 0x101b1f35 */
            ii(0x1015_757d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_757e, 5); mov(eax, StringDefinitions.AlienTanks); /* mov eax, 0x101b1ff8 */
            ii(0x1015_7583, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7584, 5); mov(eax, StringDefinitions.AlienTank);  /* mov eax, 0x101b2004 */
            ii(0x1015_7589, 1); pushd(eax);                             /* push eax */
            ii(0x1015_758a, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_758f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7590, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7592, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7593, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_7598, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7599, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_759e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_759f, 5); mov(eax, 0x75b);                        /* mov eax, 0x75b */
            ii(0x1015_75a4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75a5, 5); mov(eax, 0x38b);                        /* mov eax, 0x38b */
            ii(0x1015_75aa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75ab, 5); mov(eax, 0x737);                        /* mov eax, 0x737 */
            ii(0x1015_75b0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75b1, 5); mov(eax, 0x4ad);                        /* mov eax, 0x4ad */
            ii(0x1015_75b6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75b7, 5); mov(eax, 0x2e7);                        /* mov eax, 0x2e7 */
            ii(0x1015_75bc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75bd, 5); mov(ecx, 0xa8);                         /* mov ecx, 0xa8 */
            ii(0x1015_75c2, 5); mov(ebx, 0x51);                         /* mov ebx, 0x51 */
            ii(0x1015_75c7, 5); mov(edx, 0x1666_0100);                  /* mov edx, 0x16660100 */
            ii(0x1015_75cc, 5); mov(eax, 0x101c_a263);                  /* mov eax, 0x101ca263 */
            ii(0x1015_75d1, 5); calld(0x1015_7aaa, 0x4d4);              /* call 0x10157aaa */
            ii(0x1015_75d6, 5); calld(0x1016_4b38, 0xd55d);             /* call 0x10164b38 */
            ii(0x1015_75db, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75dc, 5); mov(eax, StringDefinitions.PowerfulPlasmaWeaponMountedOnAFastMediumArmoredChassisWhileNotAsFragileAsHumanAssaultGunsTheAlienAssaultGunShouldStillAvoidEnemy); /* mov eax, 0x101b200f */
            ii(0x1015_75e1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75e2, 5); mov(eax, StringDefinitions.AlienAssaultGuns); /* mov eax, 0x101b2116 */
            ii(0x1015_75e7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75e8, 5); mov(eax, StringDefinitions.AlienAssaultGun); /* mov eax, 0x101b2129 */
            ii(0x1015_75ed, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75ee, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_75f3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75f4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_75f6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75f7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_75fc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_75fd, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7602, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7603, 5); mov(eax, 0x75c);                        /* mov eax, 0x75c */
            ii(0x1015_7608, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7609, 5); mov(eax, 0x38c);                        /* mov eax, 0x38c */
            ii(0x1015_760e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_760f, 5); mov(eax, 0x738);                        /* mov eax, 0x738 */
            ii(0x1015_7614, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7615, 5); mov(eax, 0x4ae);                        /* mov eax, 0x4ae */
            ii(0x1015_761a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_761b, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_7620, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7621, 5); mov(ecx, 0xa9);                         /* mov ecx, 0xa9 */
            ii(0x1015_7626, 5); mov(ebx, 0x52);                         /* mov ebx, 0x52 */
            ii(0x1015_762b, 5); mov(edx, 0x1466_0100);                  /* mov edx, 0x14660100 */
            ii(0x1015_7630, 5); mov(eax, 0x101c_a28e);                  /* mov eax, 0x101ca28e */
            ii(0x1015_7635, 5); calld(0x1015_7aaa, 0x470);              /* call 0x10157aaa */
            ii(0x1015_763a, 5); calld(0x1016_4b38, 0xd4f9);             /* call 0x10164b38 */
            ii(0x1015_763f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7640, 5); mov(eax, StringDefinitions.AlienFighterBomberWhileTheAlienAttackPlaneIsPrimarilyDesignedToAttackGroundTargetsItCanAlsoFireItsMissilesAtOtherPlanesThoughPow); /* mov eax, 0x101b213b */
            ii(0x1015_7645, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7646, 5); mov(eax, StringDefinitions.AlienAttackPlanes); /* mov eax, 0x101b228f */
            ii(0x1015_764b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_764c, 5); mov(eax, StringDefinitions.AlienAttackPlane); /* mov eax, 0x101b22a3 */
            ii(0x1015_7651, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7652, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1015_7657, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7658, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_765a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_765b, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1015_7660, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7661, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7666, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7667, 5); mov(eax, 0x75d);                        /* mov eax, 0x75d */
            ii(0x1015_766c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_766d, 5); mov(eax, 0x38d);                        /* mov eax, 0x38d */
            ii(0x1015_7672, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7673, 5); mov(eax, 0x739);                        /* mov eax, 0x739 */
            ii(0x1015_7678, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7679, 5); mov(eax, 0x4af);                        /* mov eax, 0x4af */
            ii(0x1015_767e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_767f, 5); mov(eax, 0x2e2);                        /* mov eax, 0x2e2 */
            ii(0x1015_7684, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7685, 5); mov(ecx, 0xaa);                         /* mov ecx, 0xaa */
            ii(0x1015_768a, 5); mov(ebx, 0x53);                         /* mov ebx, 0x53 */
            ii(0x1015_768f, 5); mov(edx, 0x1466_0040);                  /* mov edx, 0x14660040 */
            ii(0x1015_7694, 5); mov(eax, 0x101c_a2b9);                  /* mov eax, 0x101ca2b9 */
            ii(0x1015_7699, 5); calld(0x1015_7aaa, 0x40c);              /* call 0x10157aaa */
            ii(0x1015_769e, 5); calld(0x1016_4b38, 0xd495);             /* call 0x10164b38 */
            ii(0x1015_76a3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76a4, 5); mov(eax, StringDefinitions.Empty44);    /* mov eax, 0x101b22b6 */
            ii(0x1015_76a9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76aa, 5); mov(eax, StringDefinitions.Empty45);    /* mov eax, 0x101b22b7 */
            ii(0x1015_76af, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76b0, 5); mov(eax, StringDefinitions.Missile);    /* mov eax, 0x101b22b8 */
            ii(0x1015_76b5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76b6, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_76bb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76bc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_76be, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76bf, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_76c4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76c5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_76ca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76cb, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_76d0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76d1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_76d6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76d7, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_76dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76dd, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_76e2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76e3, 5); mov(eax, 0x2f7);                        /* mov eax, 0x2f7 */
            ii(0x1015_76e8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_76e9, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_76ee, 5); mov(ebx, 0x54);                         /* mov ebx, 0x54 */
            ii(0x1015_76f3, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_76f8, 5); mov(eax, 0x101c_a2e4);                  /* mov eax, 0x101ca2e4 */
            ii(0x1015_76fd, 5); calld(0x1015_7aaa, 0x3a8);              /* call 0x10157aaa */
            ii(0x1015_7702, 5); calld(0x1016_4b38, 0xd431);             /* call 0x10164b38 */
            ii(0x1015_7707, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7708, 5); mov(eax, StringDefinitions.Empty46);    /* mov eax, 0x101b22c0 */
            ii(0x1015_770d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_770e, 5); mov(eax, StringDefinitions.Empty47);    /* mov eax, 0x101b22c1 */
            ii(0x1015_7713, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7714, 5); mov(eax, StringDefinitions.Torpedo);    /* mov eax, 0x101b22c2 */
            ii(0x1015_7719, 1); pushd(eax);                             /* push eax */
            ii(0x1015_771a, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_771f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7720, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7722, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7723, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_7728, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7729, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_772e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_772f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7734, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7735, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_773a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_773b, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7740, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7741, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7746, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7747, 5); mov(eax, 0x2f7);                        /* mov eax, 0x2f7 */
            ii(0x1015_774c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_774d, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_7752, 5); mov(ebx, 0x55);                         /* mov ebx, 0x55 */
            ii(0x1015_7757, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1015_775c, 5); mov(eax, 0x101c_a30f);                  /* mov eax, 0x101ca30f */
            ii(0x1015_7761, 5); calld(0x1015_7aaa, 0x344);              /* call 0x10157aaa */
            ii(0x1015_7766, 5); calld(0x1016_4b38, 0xd3cd);             /* call 0x10164b38 */
            ii(0x1015_776b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_776c, 5); mov(eax, StringDefinitions.Empty48);    /* mov eax, 0x101b22ca */
            ii(0x1015_7771, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7772, 5); mov(eax, StringDefinitions.Empty49);    /* mov eax, 0x101b22cb */
            ii(0x1015_7777, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7778, 5); mov(eax, StringDefinitions.AlienMissile); /* mov eax, 0x101b22cc */
            ii(0x1015_777d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_777e, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_7783, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7784, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7786, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7787, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_778c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_778d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7792, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7793, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7798, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7799, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_779e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_779f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_77a4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77a5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_77aa, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77ab, 5); mov(eax, 0x2f8);                        /* mov eax, 0x2f8 */
            ii(0x1015_77b0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77b1, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_77b6, 5); mov(ebx, 0x56);                         /* mov ebx, 0x56 */
            ii(0x1015_77bb, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_77c0, 5); mov(eax, 0x101c_a33a);                  /* mov eax, 0x101ca33a */
            ii(0x1015_77c5, 5); calld(0x1015_7aaa, 0x2e0);              /* call 0x10157aaa */
            ii(0x1015_77ca, 5); calld(0x1016_4b38, 0xd369);             /* call 0x10164b38 */
            ii(0x1015_77cf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77d0, 5); mov(eax, StringDefinitions.Empty50);    /* mov eax, 0x101b22da */
            ii(0x1015_77d5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77d6, 5); mov(eax, StringDefinitions.Empty51);    /* mov eax, 0x101b22db */
            ii(0x1015_77db, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77dc, 5); mov(eax, StringDefinitions.TankPlasmaBall); /* mov eax, 0x101b22dc */
            ii(0x1015_77e1, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77e2, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_77e7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77e8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_77ea, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77eb, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_77f0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77f1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_77f6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77f7, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_77fc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_77fd, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7802, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7803, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7808, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7809, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_780e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_780f, 5); mov(eax, 0x2f9);                        /* mov eax, 0x2f9 */
            ii(0x1015_7814, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7815, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_781a, 5); mov(ebx, 0x57);                         /* mov ebx, 0x57 */
            ii(0x1015_781f, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_7824, 5); mov(eax, 0x101c_a365);                  /* mov eax, 0x101ca365 */
            ii(0x1015_7829, 5); calld(0x1015_7aaa, 0x27c);              /* call 0x10157aaa */
            ii(0x1015_782e, 5); calld(0x1016_4b38, 0xd305);             /* call 0x10164b38 */
            ii(0x1015_7833, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7834, 5); mov(eax, StringDefinitions.Empty52);    /* mov eax, 0x101b22ed */
            ii(0x1015_7839, 1); pushd(eax);                             /* push eax */
            ii(0x1015_783a, 5); mov(eax, StringDefinitions.Empty53);    /* mov eax, 0x101b22ee */
            ii(0x1015_783f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7840, 5); mov(eax, StringDefinitions.ArtilleryPlasmaBall); /* mov eax, 0x101b22ef */
            ii(0x1015_7845, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7846, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_784b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_784c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_784e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_784f, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_7854, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7855, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_785a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_785b, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7860, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7861, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7866, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7867, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_786c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_786d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7872, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7873, 5); mov(eax, 0x2f9);                        /* mov eax, 0x2f9 */
            ii(0x1015_7878, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7879, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_787e, 5); mov(ebx, 0x58);                         /* mov ebx, 0x58 */
            ii(0x1015_7883, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_7888, 5); mov(eax, 0x101c_a390);                  /* mov eax, 0x101ca390 */
            ii(0x1015_788d, 5); calld(0x1015_7aaa, 0x218);              /* call 0x10157aaa */
            ii(0x1015_7892, 5); calld(0x1016_4b38, 0xd2a1);             /* call 0x10164b38 */
            ii(0x1015_7897, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7898, 5); mov(eax, StringDefinitions.Empty54);    /* mov eax, 0x101b2305 */
            ii(0x1015_789d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_789e, 5); mov(eax, StringDefinitions.Empty55);    /* mov eax, 0x101b2306 */
            ii(0x1015_78a3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78a4, 5); mov(eax, StringDefinitions.SmokeTrail); /* mov eax, 0x101b2307 */
            ii(0x1015_78a9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78aa, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_78af, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78b0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_78b2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78b3, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_78b8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78b9, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_78be, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78bf, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_78c4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78c5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_78ca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78cb, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_78d0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78d1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_78d6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78d7, 5); mov(eax, 0x2ec);                        /* mov eax, 0x2ec */
            ii(0x1015_78dc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78dd, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_78e2, 5); mov(ebx, 0x59);                         /* mov ebx, 0x59 */
            ii(0x1015_78e7, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x1015_78ec, 5); mov(eax, 0x101c_a3bb);                  /* mov eax, 0x101ca3bb */
            ii(0x1015_78f1, 5); calld(0x1015_7aaa, 0x1b4);              /* call 0x10157aaa */
            ii(0x1015_78f6, 5); calld(0x1016_4b38, 0xd23d);             /* call 0x10164b38 */
            ii(0x1015_78fb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_78fc, 5); mov(eax, StringDefinitions.Empty56);    /* mov eax, 0x101b2313 */
            ii(0x1015_7901, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7902, 5); mov(eax, StringDefinitions.Empty57);    /* mov eax, 0x101b2314 */
            ii(0x1015_7907, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7908, 5); mov(eax, StringDefinitions.BubbleTrail); /* mov eax, 0x101b2315 */
            ii(0x1015_790d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_790e, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_7913, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7914, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7916, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7917, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1015_791c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_791d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7922, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7923, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7928, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7929, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_792e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_792f, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7934, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7935, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_793a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_793b, 5); mov(eax, 0x2ed);                        /* mov eax, 0x2ed */
            ii(0x1015_7940, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7941, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_7946, 5); mov(ebx, 0x5a);                         /* mov ebx, 0x5a */
            ii(0x1015_794b, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
            ii(0x1015_7950, 5); mov(eax, 0x101c_a3e6);                  /* mov eax, 0x101ca3e6 */
            ii(0x1015_7955, 5); calld(0x1015_7aaa, 0x150);              /* call 0x10157aaa */
            ii(0x1015_795a, 5); calld(0x1016_4b38, 0xd1d9);             /* call 0x10164b38 */
            ii(0x1015_795f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7960, 5); mov(eax, StringDefinitions.Empty58);    /* mov eax, 0x101b2322 */
            ii(0x1015_7965, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7966, 5); mov(eax, StringDefinitions.Empty59);    /* mov eax, 0x101b2323 */
            ii(0x1015_796b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_796c, 5); mov(eax, StringDefinitions.Harvester);  /* mov eax, 0x101b2324 */
            ii(0x1015_7971, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7972, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_7977, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7978, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_797a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_797b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_7980, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7981, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7986, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7987, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_798c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_798d, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7992, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7993, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7998, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7999, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_799e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_799f, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_79a4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79a5, 5); mov(ecx, 0xab);                         /* mov ecx, 0xab */
            ii(0x1015_79aa, 5); mov(ebx, 0x5b);                         /* mov ebx, 0x5b */
            ii(0x1015_79af, 5); mov(edx, 0x200);                        /* mov edx, 0x200 */
            ii(0x1015_79b4, 5); mov(eax, 0x101c_a411);                  /* mov eax, 0x101ca411 */
            ii(0x1015_79b9, 5); calld(0x1015_7aaa, 0xec);               /* call 0x10157aaa */
            ii(0x1015_79be, 5); calld(0x1016_4b38, 0xd175);             /* call 0x10164b38 */
            ii(0x1015_79c3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79c4, 5); mov(eax, StringDefinitions.Empty60);    /* mov eax, 0x101b232e */
            ii(0x1015_79c9, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79ca, 5); mov(eax, StringDefinitions.Empty61);    /* mov eax, 0x101b232f */
            ii(0x1015_79cf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79d0, 5); mov(eax, StringDefinitions.DeadWaldo);  /* mov eax, 0x101b2330 */
            ii(0x1015_79d5, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79d6, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1015_79db, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79dc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_79de, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79df, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_79e4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79e5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_79ea, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79eb, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_79f0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79f1, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_79f6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79f7, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_79fc, 1); pushd(eax);                             /* push eax */
            ii(0x1015_79fd, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1015_7a02, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7a03, 5); mov(eax, 0x2de);                        /* mov eax, 0x2de */
            ii(0x1015_7a08, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7a09, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_7a0e, 5); mov(ebx, 0x5c);                         /* mov ebx, 0x5c */
            ii(0x1015_7a13, 5); mov(edx, 0x201);                        /* mov edx, 0x201 */
            ii(0x1015_7a18, 5); mov(eax, 0x101c_a43c);                  /* mov eax, 0x101ca43c */
            ii(0x1015_7a1d, 5); calld(0x1015_7aaa, 0x88);               /* call 0x10157aaa */
            ii(0x1015_7a22, 5); mov(ebx, 0x101b_74f0);                  /* mov ebx, 0x101b74f0 */
            ii(0x1015_7a27, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1015_7a2c, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1015_7a31, 5); calld(Definitions.sys_call_ctor_arr_v2, 0xe53a); /* call 0x10165f70 */
            ii(0x1015_7a36, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1015_7a39, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1015_7a3c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_7a3f, 10); mov(memd_a32[ds, 0x101b_d910], 0xa);   /* mov dword [0x101bd910], 0xa */
            ii(0x1015_7a49, 5); mov(ecx, 0x1016_3ae5);                  /* mov ecx, 0x10163ae5 */
            ii(0x1015_7a4e, 5); mov(ebx, 0x101c_b100);                  /* mov ebx, 0x101cb100 */
            ii(0x1015_7a53, 5); mov(edx, StringDefinitions.Unitvalues); /* mov edx, 0x101b233b */
            ii(0x1015_7a58, 5); mov(eax, 0x101c_b104);                  /* mov eax, 0x101cb104 */
            ii(0x1015_7a5d, 5); calld(0x1013_b77c, -0x1_c2e6);          /* call 0x1013b77c */
            ii(0x1015_7a62, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1015_7a65, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1015_7a68, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_7a6b, 10); mov(memd_a32[ds, 0x101b_d910], 0xb);   /* mov dword [0x101bd910], 0xb */
            ii(0x1015_7a75, 5); mov(ecx, 0x1016_42dd);                  /* mov ecx, 0x101642dd */
            ii(0x1015_7a7a, 5); mov(ebx, 0x101c_b11a);                  /* mov ebx, 0x101cb11a */
            ii(0x1015_7a7f, 5); mov(edx, StringDefinitions.Complex);    /* mov edx, 0x101b2346 */
            ii(0x1015_7a84, 5); mov(eax, 0x101c_b11c);                  /* mov eax, 0x101cb11c */
            ii(0x1015_7a89, 5); calld(0x1013_b77c, -0x1_c312);          /* call 0x1013b77c */
            ii(0x1015_7a8e, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1015_7a91, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1015_7a94, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_7a97, 10); mov(memd_a32[ds, 0x101b_d910], 0xc);   /* mov dword [0x101bd910], 0xc */
            ii(0x1015_7aa1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7aa3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_7aa4, 1); popd(edi);                              /* pop edi */
            ii(0x1015_7aa5, 1); popd(esi);                              /* pop esi */
            ii(0x1015_7aa6, 1); popd(edx);                              /* pop edx */
            ii(0x1015_7aa7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_7aa8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_7aa9, 1); retd(); return;                         /* ret */
        }
    }
}
