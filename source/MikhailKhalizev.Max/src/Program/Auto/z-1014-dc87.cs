using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_dc87-2d663687")]
        public void Method_1014_dc87()
        {
            ii(0x1014_dc87, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_dc8c, 5); calld(Definitions.sys_check_available_stack_size, 0x1_80c1); /* call 0x10165d52 */
            ii(0x1014_dc91, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_dc92, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_dc93, 1); pushd(esi);                             /* push esi */
            ii(0x1014_dc94, 1); pushd(edi);                             /* push edi */
            ii(0x1014_dc95, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_dc96, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_dc98, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_dc9e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_dca1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_dca4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dca7, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x1014_dcaa, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1014_dcad, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x1014_dcb2, 5); mov(edx, StringDefinitions.UnitType2);  /* mov edx, 0x101ad85d */
            ii(0x1014_dcb7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dcba, 5); calld(0x1014_76e3, -0x65dc);            /* call 0x101476e3 */
            ii(0x1014_dcbf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dcc2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_dcc4, 4); mov(bx, memw_a32[ds, eax + 0x7c]);      /* mov bx, [eax+0x7c] */
            ii(0x1014_dcc8, 5); mov(edx, StringDefinitions.Id2);        /* mov edx, 0x101ad867 */
            ii(0x1014_dccd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dcd0, 5); calld(0x1014_74f5, -0x67e0);            /* call 0x101474f5 */
            ii(0x1014_dcd5, 5); mov(edx, StringDefinitions.Flags2);     /* mov edx, 0x101ad86a */
            ii(0x1014_dcda, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dcdd, 5); calld(0x1014_73de, -0x6904);            /* call 0x101473de */
            ii(0x1014_dce2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dce5, 4); test(memb_a32[ds, eax + 0x15], 0x8);    /* test byte [eax+0x15], 0x8 */
            ii(0x1014_dce9, 2); if(jzd(0x1014_dcfd, 0x12)) goto l_0x1014_dcfd; /* jz 0x1014dcfd */
            ii(0x1014_dceb, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dcf0, 5); mov(edx, StringDefinitions.SpinningTurret2); /* mov edx, 0x101ad870 */
            ii(0x1014_dcf5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dcf8, 5); calld(0x1014_777e, -0x657f);            /* call 0x1014777e */
        l_0x1014_dcfd:
            ii(0x1014_dcfd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dd00, 4); test(memb_a32[ds, eax + 0x15], 0x4);    /* test byte [eax+0x15], 0x4 */
            ii(0x1014_dd04, 2); if(jzd(0x1014_dd18, 0x12)) goto l_0x1014_dd18; /* jz 0x1014dd18 */
            ii(0x1014_dd06, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dd0b, 5); mov(edx, StringDefinitions.SentryUnit2); /* mov edx, 0x101ad880 */
            ii(0x1014_dd10, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dd13, 5); calld(0x1014_777e, -0x659a);            /* call 0x1014777e */
        l_0x1014_dd18:
            ii(0x1014_dd18, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dd1b, 4); test(memb_a32[ds, eax + 0x15], 0x2);    /* test byte [eax+0x15], 0x2 */
            ii(0x1014_dd1f, 2); if(jzd(0x1014_dd33, 0x12)) goto l_0x1014_dd33; /* jz 0x1014dd33 */
            ii(0x1014_dd21, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dd26, 5); mov(edx, StringDefinitions.TurretSprite2); /* mov edx, 0x101ad88c */
            ii(0x1014_dd2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dd2e, 5); calld(0x1014_777e, -0x65b5);            /* call 0x1014777e */
        l_0x1014_dd33:
            ii(0x1014_dd33, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dd36, 4); test(memb_a32[ds, eax + 0x15], 0x1);    /* test byte [eax+0x15], 0x1 */
            ii(0x1014_dd3a, 2); if(jzd(0x1014_dd4e, 0x12)) goto l_0x1014_dd4e; /* jz 0x1014dd4e */
            ii(0x1014_dd3c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dd41, 5); mov(edx, StringDefinitions.RequiresSlab2); /* mov edx, 0x101ad89a */
            ii(0x1014_dd46, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dd49, 5); calld(0x1014_777e, -0x65d0);            /* call 0x1014777e */
        l_0x1014_dd4e:
            ii(0x1014_dd4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dd51, 4); test(memb_a32[ds, eax + 0x14], 0x80);   /* test byte [eax+0x14], 0x80 */
            ii(0x1014_dd55, 2); if(jzd(0x1014_dd69, 0x12)) goto l_0x1014_dd69; /* jz 0x1014dd69 */
            ii(0x1014_dd57, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dd5c, 5); mov(edx, StringDefinitions.Standalone2); /* mov edx, 0x101ad8a8 */
            ii(0x1014_dd61, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dd64, 5); calld(0x1014_777e, -0x65eb);            /* call 0x1014777e */
        l_0x1014_dd69:
            ii(0x1014_dd69, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dd6c, 4); test(memb_a32[ds, eax + 0x14], 0x40);   /* test byte [eax+0x14], 0x40 */
            ii(0x1014_dd70, 2); if(jzd(0x1014_dd84, 0x12)) goto l_0x1014_dd84; /* jz 0x1014dd84 */
            ii(0x1014_dd72, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dd77, 5); mov(edx, StringDefinitions.Selectable2); /* mov edx, 0x101ad8b3 */
            ii(0x1014_dd7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dd7f, 5); calld(0x1014_777e, -0x6606);            /* call 0x1014777e */
        l_0x1014_dd84:
            ii(0x1014_dd84, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dd87, 4); test(memb_a32[ds, eax + 0x14], 0x20);   /* test byte [eax+0x14], 0x20 */
            ii(0x1014_dd8b, 2); if(jzd(0x1014_dd9f, 0x12)) goto l_0x1014_dd9f; /* jz 0x1014dd9f */
            ii(0x1014_dd8d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dd92, 5); mov(edx, StringDefinitions.ElectronicUnit2); /* mov edx, 0x101ad8be */
            ii(0x1014_dd97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dd9a, 5); calld(0x1014_777e, -0x6621);            /* call 0x1014777e */
        l_0x1014_dd9f:
            ii(0x1014_dd9f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dda2, 4); test(memb_a32[ds, eax + 0x14], 0x8);    /* test byte [eax+0x14], 0x8 */
            ii(0x1014_dda6, 2); if(jzd(0x1014_ddba, 0x12)) goto l_0x1014_ddba; /* jz 0x1014ddba */
            ii(0x1014_dda8, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ddad, 5); mov(edx, StringDefinitions.ConstructorUnit2); /* mov edx, 0x101ad8ce */
            ii(0x1014_ddb2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ddb5, 5); calld(0x1014_777e, -0x663c);            /* call 0x1014777e */
        l_0x1014_ddba:
            ii(0x1014_ddba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ddbd, 4); test(memb_a32[ds, eax + 0x14], 0x4);    /* test byte [eax+0x14], 0x4 */
            ii(0x1014_ddc1, 2); if(jzd(0x1014_ddd5, 0x12)) goto l_0x1014_ddd5; /* jz 0x1014ddd5 */
            ii(0x1014_ddc3, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ddc8, 5); mov(edx, StringDefinitions.FiresMissiles2); /* mov edx, 0x101ad8df */
            ii(0x1014_ddcd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ddd0, 5); calld(0x1014_777e, -0x6657);            /* call 0x1014777e */
        l_0x1014_ddd5:
            ii(0x1014_ddd5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ddd8, 4); test(memb_a32[ds, eax + 0x14], 0x2);    /* test byte [eax+0x14], 0x2 */
            ii(0x1014_dddc, 2); if(jzd(0x1014_ddf0, 0x12)) goto l_0x1014_ddf0; /* jz 0x1014ddf0 */
            ii(0x1014_ddde, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dde3, 5); mov(edx, StringDefinitions.HasFiringSprite2); /* mov edx, 0x101ad8ee */
            ii(0x1014_dde8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ddeb, 5); calld(0x1014_777e, -0x6672);            /* call 0x1014777e */
        l_0x1014_ddf0:
            ii(0x1014_ddf0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ddf3, 4); test(memb_a32[ds, eax + 0x14], 0x1);    /* test byte [eax+0x14], 0x1 */
            ii(0x1014_ddf7, 2); if(jzd(0x1014_de0b, 0x12)) goto l_0x1014_de0b; /* jz 0x1014de0b */
            ii(0x1014_ddf9, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ddfe, 5); mov(edx, StringDefinitions.Hovering2);  /* mov edx, 0x101ad900 */
            ii(0x1014_de03, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_de06, 5); calld(0x1014_777e, -0x668d);            /* call 0x1014777e */
        l_0x1014_de0b:
            ii(0x1014_de0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_de0e, 4); test(memb_a32[ds, eax + 0x13], 0x40);   /* test byte [eax+0x13], 0x40 */
            ii(0x1014_de12, 2); if(jzd(0x1014_de26, 0x12)) goto l_0x1014_de26; /* jz 0x1014de26 */
            ii(0x1014_de14, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_de19, 5); mov(edx, StringDefinitions.Upgradeable2); /* mov edx, 0x101ad909 */
            ii(0x1014_de1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_de21, 5); calld(0x1014_777e, -0x66a8);            /* call 0x1014777e */
        l_0x1014_de26:
            ii(0x1014_de26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_de29, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1014_de2d, 2); if(jzd(0x1014_de41, 0x12)) goto l_0x1014_de41; /* jz 0x1014de41 */
            ii(0x1014_de2f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_de34, 5); mov(edx, StringDefinitions.Stationary2); /* mov edx, 0x101ad915 */
            ii(0x1014_de39, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_de3c, 5); calld(0x1014_777e, -0x66c3);            /* call 0x1014777e */
        l_0x1014_de41:
            ii(0x1014_de41, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_de44, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x1014_de48, 2); if(jzd(0x1014_de5c, 0x12)) goto l_0x1014_de5c; /* jz 0x1014de5c */
            ii(0x1014_de4a, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_de4f, 5); mov(edx, StringDefinitions.MobileLandUnit2); /* mov edx, 0x101ad920 */
            ii(0x1014_de54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_de57, 5); calld(0x1014_777e, -0x66de);            /* call 0x1014777e */
        l_0x1014_de5c:
            ii(0x1014_de5c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_de5f, 4); test(memb_a32[ds, eax + 0x12], 0x80);   /* test byte [eax+0x12], 0x80 */
            ii(0x1014_de63, 2); if(jzd(0x1014_de77, 0x12)) goto l_0x1014_de77; /* jz 0x1014de77 */
            ii(0x1014_de65, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_de6a, 5); mov(edx, StringDefinitions.MobileSeaUnit2); /* mov edx, 0x101ad931 */
            ii(0x1014_de6f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_de72, 5); calld(0x1014_777e, -0x66f9);            /* call 0x1014777e */
        l_0x1014_de77:
            ii(0x1014_de77, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_de7a, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1014_de7e, 2); if(jzd(0x1014_de92, 0x12)) goto l_0x1014_de92; /* jz 0x1014de92 */
            ii(0x1014_de80, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_de85, 5); mov(edx, StringDefinitions.MobileAirUnit2); /* mov edx, 0x101ad941 */
            ii(0x1014_de8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_de8d, 5); calld(0x1014_777e, -0x6714);            /* call 0x1014777e */
        l_0x1014_de92:
            ii(0x1014_de92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_de95, 4); test(memb_a32[ds, eax + 0x12], 0x20);   /* test byte [eax+0x12], 0x20 */
            ii(0x1014_de99, 2); if(jzd(0x1014_dead, 0x12)) goto l_0x1014_dead; /* jz 0x1014dead */
            ii(0x1014_de9b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_dea0, 5); mov(edx, StringDefinitions.MissileUnit2); /* mov edx, 0x101ad951 */
            ii(0x1014_dea5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dea8, 5); calld(0x1014_777e, -0x672f);            /* call 0x1014777e */
        l_0x1014_dead:
            ii(0x1014_dead, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_deb0, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1014_deb4, 2); if(jzd(0x1014_dec8, 0x12)) goto l_0x1014_dec8; /* jz 0x1014dec8 */
            ii(0x1014_deb6, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_debb, 5); mov(edx, StringDefinitions.Building2);  /* mov edx, 0x101ad95e */
            ii(0x1014_dec0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dec3, 5); calld(0x1014_777e, -0x674a);            /* call 0x1014777e */
        l_0x1014_dec8:
            ii(0x1014_dec8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_decb, 4); test(memb_a32[ds, eax + 0x12], 0x8);    /* test byte [eax+0x12], 0x8 */
            ii(0x1014_decf, 2); if(jzd(0x1014_dee3, 0x12)) goto l_0x1014_dee3; /* jz 0x1014dee3 */
            ii(0x1014_ded1, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ded6, 5); mov(edx, StringDefinitions.ConnectorUnit2); /* mov edx, 0x101ad967 */
            ii(0x1014_dedb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dede, 5); calld(0x1014_777e, -0x6765);            /* call 0x1014777e */
        l_0x1014_dee3:
            ii(0x1014_dee3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dee6, 4); test(memb_a32[ds, eax + 0x12], 0x4);    /* test byte [eax+0x12], 0x4 */
            ii(0x1014_deea, 2); if(jzd(0x1014_defe, 0x12)) goto l_0x1014_defe; /* jz 0x1014defe */
            ii(0x1014_deec, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_def1, 5); mov(edx, StringDefinitions.Animated2);  /* mov edx, 0x101ad976 */
            ii(0x1014_def6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_def9, 5); calld(0x1014_777e, -0x6780);            /* call 0x1014777e */
        l_0x1014_defe:
            ii(0x1014_defe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_df01, 4); test(memb_a32[ds, eax + 0x12], 0x2);    /* test byte [eax+0x12], 0x2 */
            ii(0x1014_df05, 2); if(jzd(0x1014_df19, 0x12)) goto l_0x1014_df19; /* jz 0x1014df19 */
            ii(0x1014_df07, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_df0c, 5); mov(edx, StringDefinitions.Exploding2); /* mov edx, 0x101ad97f */
            ii(0x1014_df11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_df14, 5); calld(0x1014_777e, -0x679b);            /* call 0x1014777e */
        l_0x1014_df19:
            ii(0x1014_df19, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_df1c, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x1014_df20, 2); if(jzd(0x1014_df34, 0x12)) goto l_0x1014_df34; /* jz 0x1014df34 */
            ii(0x1014_df22, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_df27, 5); mov(edx, StringDefinitions.GroundCover2); /* mov edx, 0x101ad989 */
            ii(0x1014_df2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_df2f, 5); calld(0x1014_777e, -0x67b6);            /* call 0x1014777e */
        l_0x1014_df34:
            ii(0x1014_df34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_df37, 5); calld(0x1014_7446, -0x6af6);            /* call 0x10147446 */
            ii(0x1014_df3c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_df3f, 3); mov(ebx, memd_a32[ds, eax + 0x14]);     /* mov ebx, [eax+0x14] */
            ii(0x1014_df42, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_df45, 5); mov(edx, StringDefinitions.X10);        /* mov edx, 0x101ad996 */
            ii(0x1014_df4a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_df4d, 5); calld(0x1014_74f5, -0x6a5d);            /* call 0x101474f5 */
            ii(0x1014_df52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_df55, 3); mov(ebx, memd_a32[ds, eax + 0x16]);     /* mov ebx, [eax+0x16] */
            ii(0x1014_df58, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_df5b, 5); mov(edx, StringDefinitions.Y8);         /* mov edx, 0x101ad998 */
            ii(0x1014_df60, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_df63, 5); calld(0x1014_74f5, -0x6a73);            /* call 0x101474f5 */
            ii(0x1014_df68, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_df6b, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1014_df6e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_df71, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x1014_df74, 5); mov(edx, StringDefinitions.GridX2);     /* mov edx, 0x101ad99a */
            ii(0x1014_df79, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_df7c, 5); calld(0x1014_74f5, -0x6a8c);            /* call 0x101474f5 */
            ii(0x1014_df81, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_df84, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1014_df87, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_df8a, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x1014_df8d, 5); mov(edx, StringDefinitions.GridY2);     /* mov edx, 0x101ad9a1 */
            ii(0x1014_df92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_df95, 5); calld(0x1014_74f5, -0x6aa5);            /* call 0x101474f5 */
            ii(0x1014_df9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_df9d, 7); cmp(memd_a32[ds, eax + 0xa7], 0);       /* cmp dword [eax+0xa7], 0x0 */
            ii(0x1014_dfa4, 2); if(jnzd(0x1014_dfba, 0x14)) goto l_0x1014_dfba; /* jnz 0x1014dfba */
            ii(0x1014_dfa6, 5); mov(ebx, StringDefinitions.Empty64);    /* mov ebx, 0x101ad9a8 */
            ii(0x1014_dfab, 5); mov(edx, StringDefinitions.Name4);      /* mov edx, 0x101ad9a9 */
            ii(0x1014_dfb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dfb3, 5); calld(0x1014_7489, -0x6b2f);            /* call 0x10147489 */
            ii(0x1014_dfb8, 2); jmpd(0x1014_dfd0, 0x16); goto l_0x1014_dfd0; /* jmp 0x1014dfd0 */
        l_0x1014_dfba:
            ii(0x1014_dfba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dfbd, 6); mov(ebx, memd_a32[ds, eax + 0xa7]);     /* mov ebx, [eax+0xa7] */
            ii(0x1014_dfc3, 5); mov(edx, StringDefinitions.Name5);      /* mov edx, 0x101ad9ae */
            ii(0x1014_dfc8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dfcb, 5); calld(0x1014_7489, -0x6b47);            /* call 0x10147489 */
        l_0x1014_dfd0:
            ii(0x1014_dfd0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dfd3, 6); mov(ebx, memd_a32[ds, eax + 0xd7]);     /* mov ebx, [eax+0xd7] */
            ii(0x1014_dfd9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_dfdc, 5); mov(edx, StringDefinitions.ShadowOffsetX2); /* mov edx, 0x101ad9b3 */
            ii(0x1014_dfe1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dfe4, 5); calld(0x1014_74f5, -0x6af4);            /* call 0x101474f5 */
            ii(0x1014_dfe9, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_dfec, 6); mov(ebx, memd_a32[ds, ebx + 0xd9]);     /* mov ebx, [ebx+0xd9] */
            ii(0x1014_dff2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_dff5, 5); mov(edx, StringDefinitions.ShadowOffsetY2); /* mov edx, 0x101ad9c3 */
            ii(0x1014_dffa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dffd, 5); calld(0x1014_74f5, -0x6b0d);            /* call 0x101474f5 */
            ii(0x1014_e002, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_e005, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_e007, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1014_e00a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e00d, 5); mov(ebx, 0x101c_715c);                  /* mov ebx, 0x101c715c */
            ii(0x1014_e012, 5); mov(edx, StringDefinitions.Team2);      /* mov edx, 0x101ad9d3 */
            ii(0x1014_e017, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e01a, 5); calld(0x1014_76e3, -0x693c);            /* call 0x101476e3 */
            ii(0x1014_e01f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e022, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e024, 3); mov(bl, memb_a32[ds, eax + 0x27]);      /* mov bl, [eax+0x27] */
            ii(0x1014_e027, 5); mov(edx, StringDefinitions.UnitId2);    /* mov edx, 0x101ad9d8 */
            ii(0x1014_e02c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e02f, 5); calld(0x1014_74f5, -0x6b3f);            /* call 0x101474f5 */
            ii(0x1014_e034, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e037, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e039, 3); mov(bl, memb_a32[ds, eax + 0x28]);      /* mov bl, [eax+0x28] */
            ii(0x1014_e03c, 5); mov(edx, StringDefinitions.Brightness2); /* mov edx, 0x101ad9e0 */
            ii(0x1014_e041, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e044, 5); calld(0x1014_74f5, -0x6b54);            /* call 0x101474f5 */
            ii(0x1014_e049, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e04c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e04e, 3); mov(bl, memb_a32[ds, eax + 0x29]);      /* mov bl, [eax+0x29] */
            ii(0x1014_e051, 5); mov(edx, StringDefinitions.Angle4);     /* mov edx, 0x101ad9eb */
            ii(0x1014_e056, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e059, 5); calld(0x1014_74f5, -0x6b69);            /* call 0x101474f5 */
            ii(0x1014_e05e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e061, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e063, 6); mov(bl, memb_a32[ds, eax + 0xab]);      /* mov bl, [eax+0xab] */
            ii(0x1014_e069, 5); mov(edx, StringDefinitions.VisibleToRed2); /* mov edx, 0x101ad9f1 */
            ii(0x1014_e06e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e071, 5); calld(0x1014_777e, -0x68f8);            /* call 0x1014777e */
            ii(0x1014_e076, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e079, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e07b, 6); mov(bl, memb_a32[ds, eax + 0xac]);      /* mov bl, [eax+0xac] */
            ii(0x1014_e081, 5); mov(edx, StringDefinitions.VisibleToGreen2); /* mov edx, 0x101ada00 */
            ii(0x1014_e086, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e089, 5); calld(0x1014_777e, -0x6910);            /* call 0x1014777e */
            ii(0x1014_e08e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e091, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e093, 6); mov(bl, memb_a32[ds, eax + 0xad]);      /* mov bl, [eax+0xad] */
            ii(0x1014_e099, 5); mov(edx, StringDefinitions.VisibleToBlue2); /* mov edx, 0x101ada11 */
            ii(0x1014_e09e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e0a1, 5); calld(0x1014_777e, -0x6928);            /* call 0x1014777e */
            ii(0x1014_e0a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e0a9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e0ab, 6); mov(bl, memb_a32[ds, eax + 0xae]);      /* mov bl, [eax+0xae] */
            ii(0x1014_e0b1, 5); mov(edx, StringDefinitions.VisibleToGray2); /* mov edx, 0x101ada21 */
            ii(0x1014_e0b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e0b9, 5); calld(0x1014_777e, -0x6940);            /* call 0x1014777e */
            ii(0x1014_e0be, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e0c1, 6); mov(bl, memb_a32[ds, ebx + 0xb0]);      /* mov bl, [ebx+0xb0] */
            ii(0x1014_e0c7, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1014_e0cd, 5); mov(edx, StringDefinitions.SpottedByRed2); /* mov edx, 0x101ada31 */
            ii(0x1014_e0d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e0d5, 5); calld(0x1014_777e, -0x695c);            /* call 0x1014777e */
            ii(0x1014_e0da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e0dd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e0df, 6); mov(bl, memb_a32[ds, eax + 0xb1]);      /* mov bl, [eax+0xb1] */
            ii(0x1014_e0e5, 5); mov(edx, StringDefinitions.SpottedByGreen2); /* mov edx, 0x101ada40 */
            ii(0x1014_e0ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e0ed, 5); calld(0x1014_777e, -0x6974);            /* call 0x1014777e */
            ii(0x1014_e0f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e0f5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e0f7, 6); mov(bl, memb_a32[ds, eax + 0xb2]);      /* mov bl, [eax+0xb2] */
            ii(0x1014_e0fd, 5); mov(edx, StringDefinitions.SpottedByBlue2); /* mov edx, 0x101ada51 */
            ii(0x1014_e102, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e105, 5); calld(0x1014_777e, -0x698c);            /* call 0x1014777e */
            ii(0x1014_e10a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e10d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e10f, 6); mov(bl, memb_a32[ds, eax + 0xb3]);      /* mov bl, [eax+0xb3] */
            ii(0x1014_e115, 5); mov(edx, StringDefinitions.SpottedByGray2); /* mov edx, 0x101ada61 */
            ii(0x1014_e11a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e11d, 5); calld(0x1014_777e, -0x69a4);            /* call 0x1014777e */
            ii(0x1014_e122, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e125, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e127, 3); mov(bl, memb_a32[ds, eax + 0x2a]);      /* mov bl, [eax+0x2a] */
            ii(0x1014_e12a, 5); mov(edx, StringDefinitions.MaxVelocity2); /* mov edx, 0x101ada71 */
            ii(0x1014_e12f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e132, 5); calld(0x1014_74f5, -0x6c42);            /* call 0x101474f5 */
            ii(0x1014_e137, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e13a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e13c, 3); mov(bl, memb_a32[ds, eax + 0x2b]);      /* mov bl, [eax+0x2b] */
            ii(0x1014_e13f, 5); mov(edx, StringDefinitions.Velocity2);  /* mov edx, 0x101ada7e */
            ii(0x1014_e144, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e147, 5); calld(0x1014_74f5, -0x6c57);            /* call 0x101474f5 */
            ii(0x1014_e14c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_e14f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_e151, 3); mov(al, memb_a32[ds, edx + 0x2c]);      /* mov al, [edx+0x2c] */
            ii(0x1014_e154, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e157, 5); mov(ebx, 0x101c_71cc);                  /* mov ebx, 0x101c71cc */
            ii(0x1014_e15c, 5); mov(edx, StringDefinitions.Sound2);     /* mov edx, 0x101ada87 */
            ii(0x1014_e161, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e164, 5); calld(0x1014_76e3, -0x6a86);            /* call 0x101476e3 */
            ii(0x1014_e169, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e16c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e16e, 3); mov(bl, memb_a32[ds, eax + 0x2d]);      /* mov bl, [eax+0x2d] */
            ii(0x1014_e171, 5); mov(edx, StringDefinitions.ScalerAdjust2); /* mov edx, 0x101ada8d */
            ii(0x1014_e176, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e179, 5); calld(0x1014_74f5, -0x6c89);            /* call 0x101474f5 */
            ii(0x1014_e17e, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e181, 3); mov(bl, memb_a32[ds, ebx + 0x2e]);      /* mov bl, [ebx+0x2e] */
            ii(0x1014_e184, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1014_e18a, 5); mov(edx, StringDefinitions.TurretAngle2); /* mov edx, 0x101ada9b */
            ii(0x1014_e18f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e192, 5); calld(0x1014_74f5, -0x6ca2);            /* call 0x101474f5 */
            ii(0x1014_e197, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e19a, 3); mov(ebx, memd_a32[ds, ebx + 0x2c]);     /* mov ebx, [ebx+0x2c] */
            ii(0x1014_e19d, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1014_e1a0, 5); mov(edx, StringDefinitions.TurretOffsetX2); /* mov edx, 0x101adaa8 */
            ii(0x1014_e1a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e1a8, 5); calld(0x1014_74f5, -0x6cb8);            /* call 0x101474f5 */
            ii(0x1014_e1ad, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e1b0, 3); mov(ebx, memd_a32[ds, ebx + 0x2d]);     /* mov ebx, [ebx+0x2d] */
            ii(0x1014_e1b3, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1014_e1b6, 5); mov(edx, StringDefinitions.TurretOffsetY2); /* mov edx, 0x101adab8 */
            ii(0x1014_e1bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e1be, 5); calld(0x1014_74f5, -0x6cce);            /* call 0x101474f5 */
            ii(0x1014_e1c3, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e1c6, 3); mov(ebx, memd_a32[ds, ebx + 0x2f]);     /* mov ebx, [ebx+0x2f] */
            ii(0x1014_e1c9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e1cc, 5); mov(edx, StringDefinitions.TotalImages2); /* mov edx, 0x101adac8 */
            ii(0x1014_e1d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e1d4, 5); calld(0x1014_74f5, -0x6ce4);            /* call 0x101474f5 */
            ii(0x1014_e1d9, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e1dc, 3); mov(ebx, memd_a32[ds, ebx + 0x31]);     /* mov ebx, [ebx+0x31] */
            ii(0x1014_e1df, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e1e2, 5); mov(edx, StringDefinitions.ImageBase2); /* mov edx, 0x101adad5 */
            ii(0x1014_e1e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e1ea, 5); calld(0x1014_74f5, -0x6cfa);            /* call 0x101474f5 */
            ii(0x1014_e1ef, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e1f2, 3); mov(ebx, memd_a32[ds, ebx + 0x33]);     /* mov ebx, [ebx+0x33] */
            ii(0x1014_e1f5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e1f8, 5); mov(edx, StringDefinitions.TurretImageBase2); /* mov edx, 0x101adae0 */
            ii(0x1014_e1fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e200, 5); calld(0x1014_74f5, -0x6d10);            /* call 0x101474f5 */
            ii(0x1014_e205, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e208, 3); mov(ebx, memd_a32[ds, ebx + 0x35]);     /* mov ebx, [ebx+0x35] */
            ii(0x1014_e20b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e20e, 5); mov(edx, StringDefinitions.FiringImageBase2); /* mov edx, 0x101adaf2 */
            ii(0x1014_e213, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e216, 5); calld(0x1014_74f5, -0x6d26);            /* call 0x101474f5 */
            ii(0x1014_e21b, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e21e, 3); mov(ebx, memd_a32[ds, ebx + 0x37]);     /* mov ebx, [ebx+0x37] */
            ii(0x1014_e221, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e224, 5); mov(edx, StringDefinitions.ConnectorImageBase2); /* mov edx, 0x101adb04 */
            ii(0x1014_e229, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e22c, 5); calld(0x1014_74f5, -0x6d3c);            /* call 0x101474f5 */
            ii(0x1014_e231, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e234, 6); mov(ebx, memd_a32[ds, ebx + 0xd3]);     /* mov ebx, [ebx+0xd3] */
            ii(0x1014_e23a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e23d, 5); mov(edx, StringDefinitions.ImageIndex2); /* mov edx, 0x101adb19 */
            ii(0x1014_e242, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e245, 5); calld(0x1014_74f5, -0x6d55);            /* call 0x101474f5 */
            ii(0x1014_e24a, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e24d, 6); mov(ebx, memd_a32[ds, ebx + 0xd5]);     /* mov ebx, [ebx+0xd5] */
            ii(0x1014_e253, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e256, 5); mov(edx, StringDefinitions.TurretImageIndex2); /* mov edx, 0x101adb25 */
            ii(0x1014_e25b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e25e, 5); calld(0x1014_74f5, -0x6d6e);            /* call 0x101474f5 */
            ii(0x1014_e263, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e266, 3); mov(ebx, memd_a32[ds, ebx + 0x39]);     /* mov ebx, [ebx+0x39] */
            ii(0x1014_e269, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e26c, 5); mov(edx, StringDefinitions.ImageIndexMax2); /* mov edx, 0x101adb38 */
            ii(0x1014_e271, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e274, 5); calld(0x1014_74f5, -0x6d84);            /* call 0x101474f5 */
            ii(0x1014_e279, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e27c, 5); movsx(ax, memb_a32[ds, eax + 0x3d]);    /* movsx ax, byte [eax+0x3d] */
            ii(0x1014_e281, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e284, 5); mov(ebx, 0x101c_71e8);                  /* mov ebx, 0x101c71e8 */
            ii(0x1014_e289, 5); mov(edx, StringDefinitions.Orders2);    /* mov edx, 0x101adb48 */
            ii(0x1014_e28e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e291, 5); calld(0x1014_76e3, -0x6bb3);            /* call 0x101476e3 */
            ii(0x1014_e296, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e299, 5); movsx(ax, memb_a32[ds, eax + 0x3e]);    /* movsx ax, byte [eax+0x3e] */
            ii(0x1014_e29e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e2a1, 5); mov(ebx, 0x101c_7204);                  /* mov ebx, 0x101c7204 */
            ii(0x1014_e2a6, 5); mov(edx, StringDefinitions.State2);     /* mov edx, 0x101adb4f */
            ii(0x1014_e2ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e2ae, 5); calld(0x1014_76e3, -0x6bd0);            /* call 0x101476e3 */
            ii(0x1014_e2b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e2b6, 5); movsx(ax, memb_a32[ds, eax + 0x3f]);    /* movsx ax, byte [eax+0x3f] */
            ii(0x1014_e2bb, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e2be, 5); mov(ebx, 0x101c_71e8);                  /* mov ebx, 0x101c71e8 */
            ii(0x1014_e2c3, 5); mov(edx, StringDefinitions.PriorOrders2); /* mov edx, 0x101adb55 */
            ii(0x1014_e2c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e2cb, 5); calld(0x1014_76e3, -0x6bed);            /* call 0x101476e3 */
            ii(0x1014_e2d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e2d3, 5); movsx(ax, memb_a32[ds, eax + 0x40]);    /* movsx ax, byte [eax+0x40] */
            ii(0x1014_e2d8, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e2db, 5); mov(ebx, 0x101c_7204);                  /* mov ebx, 0x101c7204 */
            ii(0x1014_e2e0, 5); mov(edx, StringDefinitions.PriorState2); /* mov edx, 0x101adb62 */
            ii(0x1014_e2e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e2e8, 5); calld(0x1014_76e3, -0x6c0a);            /* call 0x101476e3 */
            ii(0x1014_e2ed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e2f0, 8); movsx(ax, memb_a32[ds, eax + 0xa6]);    /* movsx ax, byte [eax+0xa6] */
            ii(0x1014_e2f8, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e2fb, 5); mov(ebx, 0x101c_7220);                  /* mov ebx, 0x101c7220 */
            ii(0x1014_e300, 5); mov(edx, StringDefinitions.LayingState2); /* mov edx, 0x101adb6e */
            ii(0x1014_e305, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e308, 5); calld(0x1014_76e3, -0x6c2a);            /* call 0x101476e3 */
            ii(0x1014_e30d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e310, 3); mov(ebx, memd_a32[ds, ebx + 0x3f]);     /* mov ebx, [ebx+0x3f] */
            ii(0x1014_e313, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e316, 5); mov(edx, StringDefinitions.TargetGridX2); /* mov edx, 0x101adb7b */
            ii(0x1014_e31b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e31e, 5); calld(0x1014_74f5, -0x6e2e);            /* call 0x101474f5 */
            ii(0x1014_e323, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e326, 3); mov(ebx, memd_a32[ds, ebx + 0x41]);     /* mov ebx, [ebx+0x41] */
            ii(0x1014_e329, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e32c, 5); mov(edx, StringDefinitions.TargetGridY2); /* mov edx, 0x101adb89 */
            ii(0x1014_e331, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e334, 5); calld(0x1014_74f5, -0x6e44);            /* call 0x101474f5 */
            ii(0x1014_e339, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e33c, 3); mov(bl, memb_a32[ds, ebx + 0x45]);      /* mov bl, [ebx+0x45] */
            ii(0x1014_e33f, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1014_e345, 5); mov(edx, StringDefinitions.BuildTime2); /* mov edx, 0x101adb97 */
            ii(0x1014_e34a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e34d, 5); calld(0x1014_74f5, -0x6e5d);            /* call 0x101474f5 */
            ii(0x1014_e352, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e355, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e357, 3); mov(bl, memb_a32[ds, eax + 0x46]);      /* mov bl, [eax+0x46] */
            ii(0x1014_e35a, 5); mov(edx, StringDefinitions.TotalMining2); /* mov edx, 0x101adba2 */
            ii(0x1014_e35f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e362, 5); calld(0x1014_74f5, -0x6e72);            /* call 0x101474f5 */
            ii(0x1014_e367, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e36a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e36c, 3); mov(bl, memb_a32[ds, eax + 0x47]);      /* mov bl, [eax+0x47] */
            ii(0x1014_e36f, 5); mov(edx, StringDefinitions.RawMining2); /* mov edx, 0x101adbaf */
            ii(0x1014_e374, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e377, 5); calld(0x1014_74f5, -0x6e87);            /* call 0x101474f5 */
            ii(0x1014_e37c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e37f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e381, 3); mov(bl, memb_a32[ds, eax + 0x48]);      /* mov bl, [eax+0x48] */
            ii(0x1014_e384, 5); mov(edx, StringDefinitions.FuelMining2); /* mov edx, 0x101adbba */
            ii(0x1014_e389, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e38c, 5); calld(0x1014_74f5, -0x6e9c);            /* call 0x101474f5 */
            ii(0x1014_e391, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e394, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e396, 3); mov(bl, memb_a32[ds, eax + 0x49]);      /* mov bl, [eax+0x49] */
            ii(0x1014_e399, 5); mov(edx, StringDefinitions.GoldMining2); /* mov edx, 0x101adbc6 */
            ii(0x1014_e39e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e3a1, 5); calld(0x1014_74f5, -0x6eb1);            /* call 0x101474f5 */
            ii(0x1014_e3a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e3a9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e3ab, 3); mov(bl, memb_a32[ds, eax + 0x4a]);      /* mov bl, [eax+0x4a] */
            ii(0x1014_e3ae, 5); mov(edx, StringDefinitions.RawMiningMax2); /* mov edx, 0x101adbd2 */
            ii(0x1014_e3b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e3b6, 5); calld(0x1014_74f5, -0x6ec6);            /* call 0x101474f5 */
            ii(0x1014_e3bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e3be, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e3c0, 3); mov(bl, memb_a32[ds, eax + 0x4c]);      /* mov bl, [eax+0x4c] */
            ii(0x1014_e3c3, 5); mov(edx, StringDefinitions.FuelMiningMax2); /* mov edx, 0x101adbe1 */
            ii(0x1014_e3c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e3cb, 5); calld(0x1014_74f5, -0x6edb);            /* call 0x101474f5 */
            ii(0x1014_e3d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e3d3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e3d5, 3); mov(bl, memb_a32[ds, eax + 0x4b]);      /* mov bl, [eax+0x4b] */
            ii(0x1014_e3d8, 5); mov(edx, StringDefinitions.GoldMiningMax2); /* mov edx, 0x101adbf1 */
            ii(0x1014_e3dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e3e0, 5); calld(0x1014_74f5, -0x6ef0);            /* call 0x101474f5 */
            ii(0x1014_e3e5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e3e8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e3ea, 3); mov(bl, memb_a32[ds, eax + 0x4d]);      /* mov bl, [eax+0x4d] */
            ii(0x1014_e3ed, 5); mov(edx, StringDefinitions.Hits6);      /* mov edx, 0x101adc01 */
            ii(0x1014_e3f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e3f5, 5); calld(0x1014_74f5, -0x6f05);            /* call 0x101474f5 */
            ii(0x1014_e3fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e3fd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e3ff, 3); mov(bl, memb_a32[ds, eax + 0x4e]);      /* mov bl, [eax+0x4e] */
            ii(0x1014_e402, 5); mov(edx, StringDefinitions.Speed5);     /* mov edx, 0x101adc06 */
            ii(0x1014_e407, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e40a, 5); calld(0x1014_74f5, -0x6f1a);            /* call 0x101474f5 */
            ii(0x1014_e40f, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e412, 3); mov(bl, memb_a32[ds, ebx + 0x50]);      /* mov bl, [ebx+0x50] */
            ii(0x1014_e415, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1014_e41b, 5); mov(edx, StringDefinitions.Shots5);     /* mov edx, 0x101adc0c */
            ii(0x1014_e420, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e423, 5); calld(0x1014_74f5, -0x6f33);            /* call 0x101474f5 */
            ii(0x1014_e428, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e42b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e42d, 3); mov(bl, memb_a32[ds, eax + 0x51]);      /* mov bl, [eax+0x51] */
            ii(0x1014_e430, 5); mov(edx, StringDefinitions.MoveAndFire2); /* mov edx, 0x101adc12 */
            ii(0x1014_e435, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e438, 5); calld(0x1014_777e, -0x6cbf);            /* call 0x1014777e */
            ii(0x1014_e43d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e440, 3); mov(ebx, memd_a32[ds, ebx + 0x50]);     /* mov ebx, [ebx+0x50] */
            ii(0x1014_e443, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e446, 5); mov(edx, StringDefinitions.Storage2);   /* mov edx, 0x101adc20 */
            ii(0x1014_e44b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e44e, 5); calld(0x1014_74f5, -0x6f5e);            /* call 0x101474f5 */
            ii(0x1014_e453, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e456, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e458, 3); mov(bl, memb_a32[ds, eax + 0x54]);      /* mov bl, [eax+0x54] */
            ii(0x1014_e45b, 5); mov(edx, StringDefinitions.Ammo6);      /* mov edx, 0x101adc28 */
            ii(0x1014_e460, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e463, 5); calld(0x1014_74f5, -0x6f73);            /* call 0x101474f5 */
            ii(0x1014_e468, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e46b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e46d, 3); mov(bl, memb_a32[ds, eax + 0x55]);      /* mov bl, [eax+0x55] */
            ii(0x1014_e470, 5); mov(edx, StringDefinitions.TargetingMode2); /* mov edx, 0x101adc2d */
            ii(0x1014_e475, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e478, 5); calld(0x1014_777e, -0x6cff);            /* call 0x1014777e */
            ii(0x1014_e47d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e480, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e482, 3); mov(bl, memb_a32[ds, eax + 0x56]);      /* mov bl, [eax+0x56] */
            ii(0x1014_e485, 5); mov(edx, StringDefinitions.EnterMode2); /* mov edx, 0x101adc3c */
            ii(0x1014_e48a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e48d, 5); calld(0x1014_777e, -0x6d14);            /* call 0x1014777e */
            ii(0x1014_e492, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e495, 5); movsx(ax, memb_a32[ds, eax + 0x57]);    /* movsx ax, byte [eax+0x57] */
            ii(0x1014_e49a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e49d, 5); mov(ebx, 0x101c_723c);                  /* mov ebx, 0x101c723c */
            ii(0x1014_e4a2, 5); mov(edx, StringDefinitions.Cursor2);    /* mov edx, 0x101adc47 */
            ii(0x1014_e4a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e4aa, 5); calld(0x1014_76e3, -0x6dcc);            /* call 0x101476e3 */
            ii(0x1014_e4af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e4b2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e4b4, 3); mov(bl, memb_a32[ds, eax + 0x58]);      /* mov bl, [eax+0x58] */
            ii(0x1014_e4b7, 5); mov(edx, StringDefinitions.RecoilDelay2); /* mov edx, 0x101adc4e */
            ii(0x1014_e4bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e4bf, 5); calld(0x1014_74f5, -0x6fcf);            /* call 0x101474f5 */
            ii(0x1014_e4c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e4c7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e4c9, 3); mov(bl, memb_a32[ds, eax + 0x59]);      /* mov bl, [eax+0x59] */
            ii(0x1014_e4cc, 5); mov(edx, StringDefinitions.DelayedReaction2); /* mov edx, 0x101adc5b */
            ii(0x1014_e4d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e4d4, 5); calld(0x1014_777e, -0x6d5b);            /* call 0x1014777e */
            ii(0x1014_e4d9, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e4dc, 3); mov(bl, memb_a32[ds, ebx + 0x5a]);      /* mov bl, [ebx+0x5a] */
            ii(0x1014_e4df, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1014_e4e5, 5); mov(edx, StringDefinitions.DamagedThisTurn2); /* mov edx, 0x101adc6c */
            ii(0x1014_e4ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e4ed, 5); calld(0x1014_777e, -0x6d74);            /* call 0x1014777e */
            ii(0x1014_e4f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e4f5, 5); movsx(ax, memb_a32[ds, eax + 0x5d]);    /* movsx ax, byte [eax+0x5d] */
            ii(0x1014_e4fa, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e4fd, 5); mov(ebx, 0x101c_7194);                  /* mov ebx, 0x101c7194 */
            ii(0x1014_e502, 5); mov(edx, StringDefinitions.ResearchTopic2); /* mov edx, 0x101adc7e */
            ii(0x1014_e507, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e50a, 5); calld(0x1014_76e3, -0x6e2c);            /* call 0x101476e3 */
            ii(0x1014_e50f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e512, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e514, 3); mov(bl, memb_a32[ds, eax + 0x5e]);      /* mov bl, [eax+0x5e] */
            ii(0x1014_e517, 5); mov(edx, StringDefinitions.Moved2);     /* mov edx, 0x101adc8d */
            ii(0x1014_e51c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e51f, 5); calld(0x1014_777e, -0x6da6);            /* call 0x1014777e */
            ii(0x1014_e524, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e527, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e529, 3); mov(bl, memb_a32[ds, eax + 0x5f]);      /* mov bl, [eax+0x5f] */
            ii(0x1014_e52c, 5); mov(edx, StringDefinitions.Bobbed2);    /* mov edx, 0x101adc93 */
            ii(0x1014_e531, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e534, 5); calld(0x1014_777e, -0x6dbb);            /* call 0x1014777e */
            ii(0x1014_e539, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_e53c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_e53e, 3); mov(al, memb_a32[ds, edx + 0x60]);      /* mov al, [edx+0x60] */
            ii(0x1014_e541, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e544, 5); mov(ebx, 0x101c_7258);                  /* mov ebx, 0x101c7258 */
            ii(0x1014_e549, 5); mov(edx, StringDefinitions.Engine2);    /* mov edx, 0x101adc9a */
            ii(0x1014_e54e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e551, 5); calld(0x1014_76e3, -0x6e73);            /* call 0x101476e3 */
            ii(0x1014_e556, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_e559, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_e55b, 3); mov(al, memb_a32[ds, edx + 0x61]);      /* mov al, [edx+0x61] */
            ii(0x1014_e55e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e561, 5); mov(ebx, 0x101c_7258);                  /* mov ebx, 0x101c7258 */
            ii(0x1014_e566, 5); mov(edx, StringDefinitions.Weapon2);    /* mov edx, 0x101adca1 */
            ii(0x1014_e56b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e56e, 5); calld(0x1014_76e3, -0x6e90);            /* call 0x101476e3 */
            ii(0x1014_e573, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_e576, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_e578, 3); mov(al, memb_a32[ds, edx + 0x62]);      /* mov al, [edx+0x62] */
            ii(0x1014_e57b, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_e57e, 5); mov(ebx, 0x101c_7258);                  /* mov ebx, 0x101c7258 */
            ii(0x1014_e583, 5); mov(edx, StringDefinitions.Comm2);      /* mov edx, 0x101adca8 */
            ii(0x1014_e588, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e58b, 5); calld(0x1014_76e3, -0x6ead);            /* call 0x101476e3 */
            ii(0x1014_e590, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e593, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e595, 3); mov(bl, memb_a32[ds, eax + 0x63]);      /* mov bl, [eax+0x63] */
            ii(0x1014_e598, 5); mov(edx, StringDefinitions.FuelDistance2); /* mov edx, 0x101adcad */
            ii(0x1014_e59d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e5a0, 5); calld(0x1014_74f5, -0x70b0);            /* call 0x101474f5 */
            ii(0x1014_e5a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e5a8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e5aa, 3); mov(bl, memb_a32[ds, eax + 0x64]);      /* mov bl, [eax+0x64] */
            ii(0x1014_e5ad, 5); mov(edx, StringDefinitions.MoveFraction2); /* mov edx, 0x101adcbb */
            ii(0x1014_e5b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e5b5, 5); calld(0x1014_74f5, -0x70c5);            /* call 0x101474f5 */
            ii(0x1014_e5ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e5bd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e5bf, 3); mov(bl, memb_a32[ds, eax + 0x7b]);      /* mov bl, [eax+0x7b] */
            ii(0x1014_e5c2, 5); mov(edx, StringDefinitions.Energized2); /* mov edx, 0x101adcc9 */
            ii(0x1014_e5c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e5ca, 5); calld(0x1014_777e, -0x6e51);            /* call 0x1014777e */
            ii(0x1014_e5cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e5d2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_e5d4, 3); mov(bl, memb_a32[ds, eax + 0x7a]);      /* mov bl, [eax+0x7a] */
            ii(0x1014_e5d7, 5); mov(edx, StringDefinitions.RepeatBuild2); /* mov edx, 0x101adcd3 */
            ii(0x1014_e5dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e5df, 5); calld(0x1014_777e, -0x6e66);            /* call 0x1014777e */
            ii(0x1014_e5e4, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_e5e7, 3); mov(ebx, memd_a32[ds, ebx + 0x76]);     /* mov ebx, [ebx+0x76] */
            ii(0x1014_e5ea, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_e5ed, 5); mov(edx, StringDefinitions.BuildRate2); /* mov edx, 0x101adce0 */
            ii(0x1014_e5f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e5f5, 5); calld(0x1014_74f5, -0x7105);            /* call 0x101474f5 */
            ii(0x1014_e5fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e5fd, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_e600, 5); calld(0x1015_53e0, 0x6ddb);             /* call 0x101553e0 */
            ii(0x1014_e605, 5); mov(edx, StringDefinitions.Path3);      /* mov edx, 0x101adceb */
            ii(0x1014_e60a, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1014_e60d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_e60f, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1014_e611, 5); calld(0x1014_756a, -0x70ac);            /* call 0x1014756a */
            ii(0x1014_e616, 5); mov(edx, StringDefinitions.Connectors3); /* mov edx, 0x101adcf0 */
            ii(0x1014_e61b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e61e, 5); calld(0x1014_73de, -0x7245);            /* call 0x101473de */
            ii(0x1014_e623, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e626, 4); test(memb_a32[ds, eax + 0x69], 0x1);    /* test byte [eax+0x69], 0x1 */
            ii(0x1014_e62a, 2); if(jzd(0x1014_e63e, 0x12)) goto l_0x1014_e63e; /* jz 0x1014e63e */
            ii(0x1014_e62c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e631, 5); mov(edx, StringDefinitions.ConnectNorthLeft2); /* mov edx, 0x101adcfb */
            ii(0x1014_e636, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e639, 5); calld(0x1014_777e, -0x6ec0);            /* call 0x1014777e */
        l_0x1014_e63e:
            ii(0x1014_e63e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e641, 4); test(memb_a32[ds, eax + 0x69], 0x2);    /* test byte [eax+0x69], 0x2 */
            ii(0x1014_e645, 2); if(jzd(0x1014_e659, 0x12)) goto l_0x1014_e659; /* jz 0x1014e659 */
            ii(0x1014_e647, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e64c, 5); mov(edx, StringDefinitions.ConnectNorthRight2); /* mov edx, 0x101add0e */
            ii(0x1014_e651, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e654, 5); calld(0x1014_777e, -0x6edb);            /* call 0x1014777e */
        l_0x1014_e659:
            ii(0x1014_e659, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e65c, 4); test(memb_a32[ds, eax + 0x69], 0x4);    /* test byte [eax+0x69], 0x4 */
            ii(0x1014_e660, 2); if(jzd(0x1014_e674, 0x12)) goto l_0x1014_e674; /* jz 0x1014e674 */
            ii(0x1014_e662, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e667, 5); mov(edx, StringDefinitions.ConnectEastTop2); /* mov edx, 0x101add22 */
            ii(0x1014_e66c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e66f, 5); calld(0x1014_777e, -0x6ef6);            /* call 0x1014777e */
        l_0x1014_e674:
            ii(0x1014_e674, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e677, 4); test(memb_a32[ds, eax + 0x69], 0x8);    /* test byte [eax+0x69], 0x8 */
            ii(0x1014_e67b, 2); if(jzd(0x1014_e68f, 0x12)) goto l_0x1014_e68f; /* jz 0x1014e68f */
            ii(0x1014_e67d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e682, 5); mov(edx, StringDefinitions.ConnectEastBottom2); /* mov edx, 0x101add33 */
            ii(0x1014_e687, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e68a, 5); calld(0x1014_777e, -0x6f11);            /* call 0x1014777e */
        l_0x1014_e68f:
            ii(0x1014_e68f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e692, 4); test(memb_a32[ds, eax + 0x69], 0x10);   /* test byte [eax+0x69], 0x10 */
            ii(0x1014_e696, 2); if(jzd(0x1014_e6aa, 0x12)) goto l_0x1014_e6aa; /* jz 0x1014e6aa */
            ii(0x1014_e698, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e69d, 5); mov(edx, StringDefinitions.ConnectSouthLeft2); /* mov edx, 0x101add47 */
            ii(0x1014_e6a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e6a5, 5); calld(0x1014_777e, -0x6f2c);            /* call 0x1014777e */
        l_0x1014_e6aa:
            ii(0x1014_e6aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e6ad, 4); test(memb_a32[ds, eax + 0x69], 0x20);   /* test byte [eax+0x69], 0x20 */
            ii(0x1014_e6b1, 2); if(jzd(0x1014_e6c5, 0x12)) goto l_0x1014_e6c5; /* jz 0x1014e6c5 */
            ii(0x1014_e6b3, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e6b8, 5); mov(edx, StringDefinitions.ConnectSouthRight2); /* mov edx, 0x101add5a */
            ii(0x1014_e6bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e6c0, 5); calld(0x1014_777e, -0x6f47);            /* call 0x1014777e */
        l_0x1014_e6c5:
            ii(0x1014_e6c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e6c8, 4); test(memb_a32[ds, eax + 0x69], 0x40);   /* test byte [eax+0x69], 0x40 */
            ii(0x1014_e6cc, 2); if(jzd(0x1014_e6e0, 0x12)) goto l_0x1014_e6e0; /* jz 0x1014e6e0 */
            ii(0x1014_e6ce, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e6d3, 5); mov(edx, StringDefinitions.ConnectWestTop2); /* mov edx, 0x101add6e */
            ii(0x1014_e6d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e6db, 5); calld(0x1014_777e, -0x6f62);            /* call 0x1014777e */
        l_0x1014_e6e0:
            ii(0x1014_e6e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e6e3, 4); test(memb_a32[ds, eax + 0x69], 0x80);   /* test byte [eax+0x69], 0x80 */
            ii(0x1014_e6e7, 2); if(jzd(0x1014_e6fb, 0x12)) goto l_0x1014_e6fb; /* jz 0x1014e6fb */
            ii(0x1014_e6e9, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e6ee, 5); mov(edx, StringDefinitions.ConnectWestBottom2); /* mov edx, 0x101add7f */
            ii(0x1014_e6f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e6f6, 5); calld(0x1014_777e, -0x6f7d);            /* call 0x1014777e */
        l_0x1014_e6fb:
            ii(0x1014_e6fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e6fe, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_e702, 2); if(jzd(0x1014_e716, 0x12)) goto l_0x1014_e716; /* jz 0x1014e716 */
            ii(0x1014_e704, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_e709, 5); mov(edx, StringDefinitions.ConnectionBeingTested2); /* mov edx, 0x101add93 */
            ii(0x1014_e70e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e711, 5); calld(0x1014_777e, -0x6f98);            /* call 0x1014777e */
        l_0x1014_e716:
            ii(0x1014_e716, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e719, 5); calld(0x1014_7446, -0x72d8);            /* call 0x10147446 */
            ii(0x1014_e71e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e721, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_e724, 5); calld(0x100c_b74c, -0x8_2fdd);          /* call 0x100cb74c */
            ii(0x1014_e729, 5); mov(edx, StringDefinitions.BaseValues4); /* mov edx, 0x101addab */
            ii(0x1014_e72e, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1014_e731, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_e733, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1014_e735, 5); calld(0x1014_756a, -0x71d0);            /* call 0x1014756a */
            ii(0x1014_e73a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e73d, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_e740, 5); calld(0x1015_5314, 0x6bcf);             /* call 0x10155314 */
            ii(0x1014_e745, 5); mov(edx, StringDefinitions.Complex5);   /* mov edx, 0x101addb7 */
            ii(0x1014_e74a, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1014_e74d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_e74f, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1014_e751, 5); calld(0x1014_756a, -0x71ec);            /* call 0x1014756a */
            ii(0x1014_e756, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e759, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_e75e, 5); calld(0x1007_65d0, -0xd_8193);          /* call 0x100765d0 */
            ii(0x1014_e763, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_e765, 5); mov(edx, StringDefinitions.ParentUnit2); /* mov edx, 0x101addbf */
            ii(0x1014_e76a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_e76d, 5); calld(0x1014_756a, -0x7208);            /* call 0x1014756a */
            ii(0x1014_e772, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_e775, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_e778, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_e77b, 5); calld(0x100c_fddd, -0x7_e9a3);          /* call 0x100cfddd */
            ii(0x1014_e780, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_e782, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_e783, 1); popd(edi);                              /* pop edi */
            ii(0x1014_e784, 1); popd(esi);                              /* pop esi */
            ii(0x1014_e785, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_e786, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_e787, 1); retd();                                 /* ret */
        }
    }
}
