using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_3fc4-65868a89")]
        public void Method_100e_3fc4()
        {
            ii(0x100e_3fc4, 5); push(0x30);                             /* push 0x30 */
            ii(0x100e_3fc9, 5); call(Definitions.sys_check_available_stack_size, 0x8_1d84); /* call 0x10165d52 */
            ii(0x100e_3fce, 1); push(ebx);                              /* push ebx */
            ii(0x100e_3fcf, 1); push(ecx);                              /* push ecx */
            ii(0x100e_3fd0, 1); push(edx);                              /* push edx */
            ii(0x100e_3fd1, 1); push(esi);                              /* push esi */
            ii(0x100e_3fd2, 1); push(edi);                              /* push edi */
            ii(0x100e_3fd3, 1); push(ebp);                              /* push ebp */
            ii(0x100e_3fd4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3fd6, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_3fdc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_3fdf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_3fe2, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_3fe5, 5); call(0x1007_6338, -0x6_dcb2);           /* call 0x10076338 */
            ii(0x100e_3fea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_3fec, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_3fef, 5); call(0x1007_64b8, -0x6_db3c);           /* call 0x100764b8 */
            ii(0x100e_3ff4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_3ff7, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100e_3ffa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_3ffd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_3fff, 2); if(jnz(0x100e_4017, 0x16)) goto l_0x100e_4017; /* jnz 0x100e4017 */
            ii(0x100e_4001, 5); call(0x100d_51c4, -0xee42);             /* call 0x100d51c4 */
            ii(0x100e_4006, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4008, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_400a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_400d, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x100e_4010, 5); call(0x100c_fb06, -0x1_450f);           /* call 0x100cfb06 */
            ii(0x100e_4015, 2); jmp(0x100e_4034, 0x1d); goto l_0x100e_4034; /* jmp 0x100e4034 */
        l_0x100e_4017:
            ii(0x100e_4017, 5); call(0x100d_51e4, -0xee38);             /* call 0x100d51e4 */
            ii(0x100e_401c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_401e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_4020, 5); call(0x100d_5204, -0xee21);             /* call 0x100d5204 */
            ii(0x100e_4025, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4027, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_4029, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_402c, 3); mov(eax, memd[ds, eax + 0x60]);         /* mov eax, [eax+0x60] */
            ii(0x100e_402f, 5); call(0x100c_fa7c, -0x1_45b8);           /* call 0x100cfa7c */
        l_0x100e_4034:
            ii(0x100e_4034, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4037, 3); mov(edx, memd[ds, eax + 0x24]);         /* mov edx, [eax+0x24] */
            ii(0x100e_403a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_403d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4040, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100e_4043, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_4046, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_4048, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_404b, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_404e, 5); call(0x1007_6b90, -0x6_d4c3);           /* call 0x10076b90 */
            ii(0x100e_4053, 1); cwde();                                 /* cwde */
            ii(0x100e_4054, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_4056, 2); if(jl(0x100e_406e, 0x16)) goto l_0x100e_406e; /* jl 0x100e406e */
            ii(0x100e_4058, 5); call(0x100d_51c4, -0xee99);             /* call 0x100d51c4 */
            ii(0x100e_405d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_405f, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_4061, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4064, 3); mov(eax, memd[ds, eax + 0x64]);         /* mov eax, [eax+0x64] */
            ii(0x100e_4067, 5); call(0x100c_fb06, -0x1_4566);           /* call 0x100cfb06 */
            ii(0x100e_406c, 2); jmp(0x100e_408b, 0x1d); goto l_0x100e_408b; /* jmp 0x100e408b */
        l_0x100e_406e:
            ii(0x100e_406e, 5); call(0x100d_51e4, -0xee8f);             /* call 0x100d51e4 */
            ii(0x100e_4073, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_4075, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_4077, 5); call(0x100d_5204, -0xee78);             /* call 0x100d5204 */
            ii(0x100e_407c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_407e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_4080, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4083, 3); mov(eax, memd[ds, eax + 0x64]);         /* mov eax, [eax+0x64] */
            ii(0x100e_4086, 5); call(0x100c_fa7c, -0x1_460f);           /* call 0x100cfa7c */
        l_0x100e_408b:
            ii(0x100e_408b, 5); call(0x100d_51e4, -0xeeac);             /* call 0x100d51e4 */
            ii(0x100e_4090, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_4092, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_4094, 5); call(0x100d_5204, -0xee95);             /* call 0x100d5204 */
            ii(0x100e_4099, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_409b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_409d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_40a0, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x100e_40a3, 5); call(0x100c_fa7c, -0x1_462c);           /* call 0x100cfa7c */
            ii(0x100e_40a8, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_40ac, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_40b0, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100e_40b4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_40b7, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_40ba, 5); call(0x1007_6b90, -0x6_d52f);           /* call 0x10076b90 */
            ii(0x100e_40bf, 1); cwde();                                 /* cwde */
            ii(0x100e_40c0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_40c2, 2); if(jnz(0x100e_40e6, 0x22)) goto l_0x100e_40e6; /* jnz 0x100e40e6 */
            ii(0x100e_40c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_40c7, 4); cmp(memd[ds, eax + 0x4c], 0);           /* cmp dword [eax+0x4c], 0x0 */
            ii(0x100e_40cb, 2); if(jz(0x100e_40e1, 0x14)) goto l_0x100e_40e1; /* jz 0x100e40e1 */
            ii(0x100e_40cd, 5); call(0x100d_51c4, -0xef0e);             /* call 0x100d51c4 */
            ii(0x100e_40d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_40d4, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_40d6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_40d9, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x100e_40dc, 5); call(0x100c_fb06, -0x1_45db);           /* call 0x100cfb06 */
        l_0x100e_40e1:
            ii(0x100e_40e1, 5); jmp(0x100e_4174, 0x8e); goto l_0x100e_4174; /* jmp 0x100e4174 */
        l_0x100e_40e6:
            ii(0x100e_40e6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_40e9, 4); cmp(memd[ds, eax + 0x4c], 0);           /* cmp dword [eax+0x4c], 0x0 */
            ii(0x100e_40ed, 2); if(jz(0x100e_410c, 0x1d)) goto l_0x100e_410c; /* jz 0x100e410c */
            ii(0x100e_40ef, 5); call(0x100d_51e4, -0xef10);             /* call 0x100d51e4 */
            ii(0x100e_40f4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_40f6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_40f8, 5); call(0x100d_5204, -0xeef9);             /* call 0x100d5204 */
            ii(0x100e_40fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_40ff, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_4101, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4104, 3); mov(eax, memd[ds, eax + 0x4c]);         /* mov eax, [eax+0x4c] */
            ii(0x100e_4107, 5); call(0x100c_fa7c, -0x1_4690);           /* call 0x100cfa7c */
        l_0x100e_410c:
            ii(0x100e_410c, 2); jmp(0x100e_4116, 8); goto l_0x100e_4116; /* jmp 0x100e4116 */
        l_0x100e_410e:
            ii(0x100e_410e, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_4111, 5); call(0x1007_6bf8, -0x6_d51e);           /* call 0x10076bf8 */
        l_0x100e_4116:
            ii(0x100e_4116, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4118, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_411b, 5); call(0x1013_ad71, 0x5_6c51);            /* call 0x1013ad71 */
            ii(0x100e_4120, 2); test(al, al);                           /* test al, al */
            ii(0x100e_4122, 2); if(jz(0x100e_4174, 0x50)) goto l_0x100e_4174; /* jz 0x100e4174 */
            ii(0x100e_4124, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_4127, 5); call(0x1007_63d4, -0x6_dd58);           /* call 0x100763d4 */
            ii(0x100e_412c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_412e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4131, 5); call(0x100e_2f04, -0x1232);             /* call 0x100e2f04 */
            ii(0x100e_4136, 2); test(al, al);                           /* test al, al */
            ii(0x100e_4138, 2); if(jz(0x100e_413e, 4)) goto l_0x100e_413e; /* jz 0x100e413e */
            ii(0x100e_413a, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x100e_413e:
            ii(0x100e_413e, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_4141, 5); call(0x1007_63d4, -0x6_dd72);           /* call 0x100763d4 */
            ii(0x100e_4146, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_4148, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_414b, 5); call(0x100e_2f92, -0x11be);             /* call 0x100e2f92 */
            ii(0x100e_4150, 2); test(al, al);                           /* test al, al */
            ii(0x100e_4152, 2); if(jz(0x100e_4158, 4)) goto l_0x100e_4158; /* jz 0x100e4158 */
            ii(0x100e_4154, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
        l_0x100e_4158:
            ii(0x100e_4158, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_415b, 5); call(0x1007_63d4, -0x6_dd8c);           /* call 0x100763d4 */
            ii(0x100e_4160, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_4162, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4165, 5); call(0x100e_3020, -0x114a);             /* call 0x100e3020 */
            ii(0x100e_416a, 2); test(al, al);                           /* test al, al */
            ii(0x100e_416c, 2); if(jz(0x100e_4172, 4)) goto l_0x100e_4172; /* jz 0x100e4172 */
            ii(0x100e_416e, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x100e_4172:
            ii(0x100e_4172, 2); jmp(0x100e_410e, -0x66); goto l_0x100e_410e; /* jmp 0x100e410e */
        l_0x100e_4174:
            ii(0x100e_4174, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4177, 4); cmp(memd[ds, eax + 0x50], 0);           /* cmp dword [eax+0x50], 0x0 */
            ii(0x100e_417b, 2); if(jnz(0x100e_4189, 0xc)) goto l_0x100e_4189; /* jnz 0x100e4189 */
            ii(0x100e_417d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_417f, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_4182, 5); call(0x1007_5f6c, -0x6_e21b);           /* call 0x10075f6c */
            ii(0x100e_4187, 2); jmp(0x100e_41de, 0x55); goto l_0x100e_41de; /* jmp 0x100e41de */
        l_0x100e_4189:
            ii(0x100e_4189, 5); call(0x100d_51e4, -0xefaa);             /* call 0x100d51e4 */
            ii(0x100e_418e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_4190, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_4192, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4194, 3); mov(dl, memb[ss, ebp - 8]);             /* mov dl, [ebp-0x8] */
            ii(0x100e_4197, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_419a, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100e_419d, 5); call(0x100c_fa7c, -0x1_4726);           /* call 0x100cfa7c */
            ii(0x100e_41a2, 5); call(0x100d_51e4, -0xefc3);             /* call 0x100d51e4 */
            ii(0x100e_41a7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_41a9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_41ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_41ad, 3); mov(dl, memb[ss, ebp - 0xc]);           /* mov dl, [ebp-0xc] */
            ii(0x100e_41b0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_41b3, 3); mov(eax, memd[ds, eax + 0x54]);         /* mov eax, [eax+0x54] */
            ii(0x100e_41b6, 5); call(0x100c_fa7c, -0x1_473f);           /* call 0x100cfa7c */
            ii(0x100e_41bb, 5); call(0x100d_51e4, -0xefdc);             /* call 0x100d51e4 */
            ii(0x100e_41c0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_41c2, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_41c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_41c6, 3); mov(dl, memb[ss, ebp - 0x10]);          /* mov dl, [ebp-0x10] */
            ii(0x100e_41c9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_41cc, 3); mov(eax, memd[ds, eax + 0x58]);         /* mov eax, [eax+0x58] */
            ii(0x100e_41cf, 5); call(0x100c_fa7c, -0x1_4758);           /* call 0x100cfa7c */
            ii(0x100e_41d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_41d6, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_41d9, 5); call(0x1007_5f6c, -0x6_e272);           /* call 0x10075f6c */
        l_0x100e_41de:
            ii(0x100e_41de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_41e0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_41e1, 1); pop(edi);                               /* pop edi */
            ii(0x100e_41e2, 1); pop(esi);                               /* pop esi */
            ii(0x100e_41e3, 1); pop(edx);                               /* pop edx */
            ii(0x100e_41e4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_41e5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_41e6, 1); ret();                                  /* ret */
        }
    }
}
