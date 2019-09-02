using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_51c1-f5b61ca")]
        public void Method_1013_51c1()
        {
            ii(0x1013_51c1, 5); push(0x100);                            /* push 0x100 */
            ii(0x1013_51c6, 5); call(Definitions.sys_check_available_stack_size, 0x3_0b87); /* call 0x10165d52 */
            ii(0x1013_51cb, 1); push(ebx);                              /* push ebx */
            ii(0x1013_51cc, 1); push(ecx);                              /* push ecx */
            ii(0x1013_51cd, 1); push(edx);                              /* push edx */
            ii(0x1013_51ce, 1); push(esi);                              /* push esi */
            ii(0x1013_51cf, 1); push(edi);                              /* push edi */
            ii(0x1013_51d0, 1); push(ebp);                              /* push ebp */
            ii(0x1013_51d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_51d3, 6); sub(esp, 0xd8);                         /* sub esp, 0xd8 */
            ii(0x1013_51d9, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1013_51dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_51de, 3); mov(dl, memb[ss, ebp - 4]);             /* mov dl, [ebp-0x4] */
            ii(0x1013_51e1, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1013_51e6, 5); call(0x100c_aafc, -0x6_a6ef);           /* call 0x100caafc */
            ii(0x1013_51eb, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1013_51f0, 5); call(0x1010_2e0f, -0x3_23e6);           /* call 0x10102e0f */
            ii(0x1013_51f5, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1013_51fa, 5); call(0x1010_2e0f, -0x3_23f0);           /* call 0x10102e0f */
            ii(0x1013_51ff, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1013_5204, 5); call(0x1010_2e0f, -0x3_23fa);           /* call 0x10102e0f */
            ii(0x1013_5209, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1013_520e, 5); call(0x1010_2e0f, -0x3_2404);           /* call 0x10102e0f */
            ii(0x1013_5213, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1013_5218, 5); call(0x1010_2e0f, -0x3_240e);           /* call 0x10102e0f */
            ii(0x1013_521d, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1013_5222, 5); call(0x1010_3ff1, -0x3_1236);           /* call 0x10103ff1 */
            ii(0x1013_5227, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1013_522c, 5); call(0x1010_380b, -0x3_1a26);           /* call 0x1010380b */
            ii(0x1013_5231, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5233, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1013_5238, 5); call(0x1007_6630, -0xb_ec0d);           /* call 0x10076630 */
            ii(0x1013_523d, 7); cmp(memd[ds, 0x101c_9450], 0);          /* cmp dword [0x101c9450], 0x0 */
            ii(0x1013_5244, 2); if(jz(0x1013_5250, 0xa)) goto l_0x1013_5250; /* jz 0x10135250 */
            ii(0x1013_5246, 5); mov(eax, memd[ds, 0x101c_9450]);        /* mov eax, [0x101c9450] */
            ii(0x1013_524b, 5); call(Definitions.sys_delete, 0x3_0d14); /* call 0x10165f64 */
        l_0x1013_5250:
            ii(0x1013_5250, 7); cmp(memd[ds, 0x101c_944c], 0);          /* cmp dword [0x101c944c], 0x0 */
            ii(0x1013_5257, 2); if(jz(0x1013_5263, 0xa)) goto l_0x1013_5263; /* jz 0x10135263 */
            ii(0x1013_5259, 5); mov(eax, memd[ds, 0x101c_944c]);        /* mov eax, [0x101c944c] */
            ii(0x1013_525e, 5); call(Definitions.sys_delete, 0x3_0d01); /* call 0x10165f64 */
        l_0x1013_5263:
            ii(0x1013_5263, 7); cmp(memd[ds, 0x101c_9454], 0);          /* cmp dword [0x101c9454], 0x0 */
            ii(0x1013_526a, 2); if(jz(0x1013_5276, 0xa)) goto l_0x1013_5276; /* jz 0x10135276 */
            ii(0x1013_526c, 5); mov(eax, memd[ds, 0x101c_9454]);        /* mov eax, [0x101c9454] */
            ii(0x1013_5271, 5); call(Definitions.sys_delete, 0x3_0cee); /* call 0x10165f64 */
        l_0x1013_5276:
            ii(0x1013_5276, 7); cmp(memd[ds, 0x101c_811c], 0);          /* cmp dword [0x101c811c], 0x0 */
            ii(0x1013_527d, 2); if(jz(0x1013_5289, 0xa)) goto l_0x1013_5289; /* jz 0x10135289 */
            ii(0x1013_527f, 5); mov(eax, memd[ds, 0x101c_811c]);        /* mov eax, [0x101c811c] */
            ii(0x1013_5284, 5); call(Definitions.sys_delete, 0x3_0cdb); /* call 0x10165f64 */
        l_0x1013_5289:
            ii(0x1013_5289, 10); mov(memd[ds, 0x101c_9450], 0);         /* mov dword [0x101c9450], 0x0 */
            ii(0x1013_5293, 10); mov(memd[ds, 0x101c_944c], 0);         /* mov dword [0x101c944c], 0x0 */
            ii(0x1013_529d, 10); mov(memd[ds, 0x101c_9454], 0);         /* mov dword [0x101c9454], 0x0 */
            ii(0x1013_52a7, 10); mov(memd[ds, 0x101c_811c], 0);         /* mov dword [0x101c811c], 0x0 */
            ii(0x1013_52b1, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_52b6, 5); call(0x1013_d111, 0x7e56);              /* call 0x1013d111 */
            ii(0x1013_52bb, 5); call(0x100d_533c, -0x5_ff84);           /* call 0x100d533c */
            ii(0x1013_52c0, 1); cwde();                                 /* cwde */
            ii(0x1013_52c1, 1); push(eax);                              /* push eax */
            ii(0x1013_52c2, 5); call(0x100d_5360, -0x5_ff67);           /* call 0x100d5360 */
            ii(0x1013_52c7, 1); cwde();                                 /* cwde */
            ii(0x1013_52c8, 1); push(eax);                              /* push eax */
            ii(0x1013_52c9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_52cb, 1); push(eax);                              /* push eax */
            ii(0x1013_52cc, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1013_52d1, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1013_52d6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_52d8, 5); call(0x100e_883d, -0x4_caa0);           /* call 0x100e883d */
            ii(0x1013_52dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_52df, 5); mov(eax, 0x6be);                        /* mov eax, 0x6be */
            ii(0x1013_52e4, 5); call(0x100e_8c51, -0x4_c698);           /* call 0x100e8c51 */
            ii(0x1013_52e9, 7); cmp(memb[ds, 0x101c_391e], 7);          /* cmp byte [0x101c391e], 0x7 */
            ii(0x1013_52f0, 2); if(jnz(0x1013_52f8, 6)) goto l_0x1013_52f8; /* jnz 0x101352f8 */
            ii(0x1013_52f2, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1013_52f6, 2); jmp(0x1013_52fc, 4); goto l_0x1013_52fc; /* jmp 0x101352fc */
        l_0x1013_52f8:
            ii(0x1013_52f8, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x1013_52fc:
            ii(0x1013_52fc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_52fe, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1013_5301, 5); call(0x100f_1a86, -0x4_3880);           /* call 0x100f1a86 */
            ii(0x1013_5306, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5308, 5); call(0x100e_883d, -0x4_cad0);           /* call 0x100e883d */
            ii(0x1013_530d, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_5310, 5); call(Definitions.sys_display_draw_0, 0x3_216f); /* call 0x10167484 */
            ii(0x1013_5315, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5317, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1013_531a, 5); add(eax, 0x76e);                        /* add eax, 0x76e */
            ii(0x1013_531f, 1); cwde();                                 /* cwde */
            ii(0x1013_5320, 5); call(Definitions.my_get_res_data_by_id_malloc, -0x113a); /* call 0x101341eb */
            ii(0x1013_5325, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_5328, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1013_532c, 2); if(jnz(0x1013_5338, 0xa)) goto l_0x1013_5338; /* jnz 0x10135338 */
            ii(0x1013_532e, 5); mov(eax, 6);                            /* mov eax, 0x6 */
            ii(0x1013_5333, 5); call(0x100e_f3a0, -0x4_5f98);           /* call 0x100ef3a0 */
        l_0x1013_5338:
            ii(0x1013_5338, 5); mov(edx, StringDefinitions.Rb9);        /* mov edx, 0x101a8a10 */
            ii(0x1013_533d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_5340, 5); call(Definitions.my_fopen, -0x4_5f26);  /* call 0x100ef41f */
            ii(0x1013_5345, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_5348, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_534b, 5); call(Definitions.sys_free, 0x3_5d71);   /* call 0x1016b0c1 */
            ii(0x1013_5350, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_5354, 2); if(jnz(0x1013_5360, 0xa)) goto l_0x1013_5360; /* jnz 0x10135360 */
            ii(0x1013_5356, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1013_535b, 5); call(0x100e_f3a0, -0x4_5fc0);           /* call 0x100ef3a0 */
        l_0x1013_5360:
            ii(0x1013_5360, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_5367, 4); or(memb[ss, ebp - 24], 1);              /* or byte [ebp-0x18], 0x1 */
            ii(0x1013_536b, 5); mov(edx, StringDefinitions.ScanningPlanetSurface); /* mov edx, 0x101a8a13 */
            ii(0x1013_5370, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1013_5373, 5); call(0x1013_679b, 0x1423);              /* call 0x1013679b */
            ii(0x1013_5378, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x1013_537b, 4); and(memb[ss, ebp - 24], -2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x1013_537f, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_5382, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1013_5387, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_538c, 3); lea(eax, memd[ss, ebp - 92]);           /* lea eax, [ebp-0x5c] */
            ii(0x1013_538f, 5); call(Definitions.my_fread, -0x4_5f05);  /* call 0x100ef48f */
            ii(0x1013_5394, 3); cmp(eax, 5);                            /* cmp eax, 0x5 */
            ii(0x1013_5397, 2); if(jz(0x1013_53a3, 0xa)) goto l_0x1013_53a3; /* jz 0x101353a3 */
            ii(0x1013_5399, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_539e, 5); call(0x100e_f3a0, -0x4_6003);           /* call 0x100ef3a0 */
        l_0x1013_53a3:
            ii(0x1013_53a3, 4); movsx(eax, memw[ss, ebp - 89]);         /* movsx eax, word [ebp-0x59] */
            ii(0x1013_53a7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_53aa, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x1013_53ad, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_53b0, 3); mov(ebx, memd[ss, ebp - 96]);           /* mov ebx, [ebp-0x60] */
            ii(0x1013_53b3, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_53b8, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_53be, 5); call(Definitions.my_fread, -0x4_5f34);  /* call 0x100ef48f */
            ii(0x1013_53c3, 3); cmp(eax, memd[ss, ebp - 96]);           /* cmp eax, [ebp-0x60] */
            ii(0x1013_53c6, 2); if(jz(0x1013_53d2, 0xa)) goto l_0x1013_53d2; /* jz 0x101353d2 */
            ii(0x1013_53c8, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_53cd, 5); call(0x100e_f3a0, -0x4_6032);           /* call 0x100ef3a0 */
        l_0x1013_53d2:
            ii(0x1013_53d2, 10); mov(memd[ss, ebp - 148], 1);           /* mov dword [ebp-0x94], 0x1 */
            ii(0x1013_53dc, 7); movsx(eax, memw[ss, ebp - 148]);        /* movsx eax, word [ebp-0x94] */
            ii(0x1013_53e3, 1); dec(eax);                               /* dec eax */
            ii(0x1013_53e4, 6); imul(eax, eax, 0x3100);                 /* imul eax, eax, 0x3100 */
            ii(0x1013_53ea, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x1013_53ed, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_53f2, 3); mov(edx, memd[ss, ebp - 96]);           /* mov edx, [ebp-0x60] */
            ii(0x1013_53f5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_53f8, 5); call(Definitions.my_fseek, -0x4_5fa8);  /* call 0x100ef455 */
            ii(0x1013_53fd, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_5400, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_5405, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_540a, 5); mov(eax, memd[ds, 0x101c_70e0]);        /* mov eax, [0x101c70e0] */
            ii(0x1013_540f, 5); call(Definitions.my_fread, -0x4_5f85);  /* call 0x100ef48f */
            ii(0x1013_5414, 5); cmp(eax, 0x3100);                       /* cmp eax, 0x3100 */
            ii(0x1013_5419, 2); if(jz(0x1013_5425, 0xa)) goto l_0x1013_5425; /* jz 0x10135425 */
            ii(0x1013_541b, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_5420, 5); call(0x100e_f3a0, -0x4_6085);           /* call 0x100ef3a0 */
        l_0x1013_5425:
            ii(0x1013_5425, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_542a, 6); mov(edx, memd[ds, 0x101c_70e0]);        /* mov edx, [0x101c70e0] */
            ii(0x1013_5430, 5); mov(eax, memd[ds, 0x101c_70e8]);        /* mov eax, [0x101c70e8] */
            ii(0x1013_5435, 5); call(Definitions.sys_memcpy, 0x3_0a11); /* call 0x10165e4b */
            ii(0x1013_543a, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_543d, 5); call(Definitions.sys_ftell, 0x3_d305);  /* call 0x10172747 */
            ii(0x1013_5442, 6); mov(memd[ss, ebp - 152], eax);          /* mov [ebp-0x98], eax */
            ii(0x1013_5448, 7); movsx(eax, memw[ss, ebp - 142]);        /* movsx eax, word [ebp-0x8e] */
            ii(0x1013_544f, 7); movsx(edx, memw[ss, ebp - 144]);        /* movsx edx, word [ebp-0x90] */
            ii(0x1013_5456, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_5459, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_545b, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x1013_545e, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_5463, 3); mov(edx, memd[ss, ebp - 96]);           /* mov edx, [ebp-0x60] */
            ii(0x1013_5466, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_5469, 5); call(Definitions.my_fseek, -0x4_6019);  /* call 0x100ef455 */
            ii(0x1013_546e, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_5471, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1013_5476, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_547b, 6); lea(eax, memd[ss, ebp - 156]);          /* lea eax, [ebp-0x9c] */
            ii(0x1013_5481, 5); call(Definitions.my_fread, -0x4_5ff7);  /* call 0x100ef48f */
            ii(0x1013_5486, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1013_5489, 2); if(jz(0x1013_5495, 0xa)) goto l_0x1013_5495; /* jz 0x10135495 */
            ii(0x1013_548b, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_5490, 5); call(0x100e_f3a0, -0x4_60f5);           /* call 0x100ef3a0 */
        l_0x1013_5495:
            ii(0x1013_5495, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_549c, 3); shl(eax, 0xc);                          /* shl eax, 0xc */
            ii(0x1013_549f, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x1013_54a2, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_54a7, 3); mov(edx, memd[ss, ebp - 96]);           /* mov edx, [ebp-0x60] */
            ii(0x1013_54aa, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_54ad, 5); call(Definitions.my_fseek, -0x4_605d);  /* call 0x100ef455 */
            ii(0x1013_54b2, 5); mov(eax, 0x300);                        /* mov eax, 0x300 */
            ii(0x1013_54b7, 5); call(Definitions.sys_new_arr, 0x3_0b54); /* call 0x10166010 */
            ii(0x1013_54bc, 6); mov(memd[ss, ebp - 160], eax);          /* mov [ebp-0xa0], eax */
            ii(0x1013_54c2, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_54c5, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x1013_54ca, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_54cf, 6); mov(eax, memd[ss, ebp - 160]);          /* mov eax, [ebp-0xa0] */
            ii(0x1013_54d5, 5); call(Definitions.my_fread, -0x4_604b);  /* call 0x100ef48f */
            ii(0x1013_54da, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x1013_54df, 2); if(jz(0x1013_54eb, 0xa)) goto l_0x1013_54eb; /* jz 0x101354eb */
            ii(0x1013_54e1, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_54e6, 5); call(0x100e_f3a0, -0x4_614b);           /* call 0x100ef3a0 */
        l_0x1013_54eb:
            ii(0x1013_54eb, 10); mov(memd[ss, ebp - 156], 0xc0);        /* mov dword [ebp-0x9c], 0xc0 */
            ii(0x1013_54f5, 2); jmp(0x1013_5503, 0xc); goto l_0x1013_5503; /* jmp 0x10135503 */
        l_0x1013_54f7:
            ii(0x1013_54f7, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x1013_54fd, 6); inc(memd[ss, ebp - 156]);               /* inc dword [ebp-0x9c] */
        l_0x1013_5503:
            ii(0x1013_5503, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_550a, 5); cmp(eax, 0x1e0);                        /* cmp eax, 0x1e0 */
            ii(0x1013_550f, 2); if(jge(0x1013_553d, 0x2c)) goto l_0x1013_553d; /* jge 0x1013553d */
            ii(0x1013_5511, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5518, 6); add(eax, memd[ss, ebp - 160]);          /* add eax, [ebp-0xa0] */
            ii(0x1013_551e, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_5520, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_5525, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1013_5528, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1013_552a, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5531, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_5537, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_5539, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
            ii(0x1013_553b, 2); jmp(0x1013_54f7, -0x46); goto l_0x1013_54f7; /* jmp 0x101354f7 */
        l_0x1013_553d:
            ii(0x1013_553d, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_5542, 5); call(Definitions.sys_display_apply_palette, 0x3_7675); /* call 0x1016cbbc */
            ii(0x1013_5547, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_554c, 5); call(/* sys */ 0x1016_d2cc, 0x3_7d7b);  /* call 0x1016d2cc */
            ii(0x1013_5551, 6); mov(eax, memd[ss, ebp - 160]);          /* mov eax, [ebp-0xa0] */
            ii(0x1013_5557, 5); call(Definitions.sys_delete, 0x3_0a08); /* call 0x10165f64 */
            ii(0x1013_555c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_555e, 6); mov(edx, memd[ss, ebp - 152]);          /* mov edx, [ebp-0x98] */
            ii(0x1013_5564, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_5567, 5); call(Definitions.my_fseek, -0x4_6117);  /* call 0x100ef455 */
            ii(0x1013_556c, 4); movsx(edx, memw[ss, ebp - 89]);         /* movsx edx, word [ebp-0x59] */
            ii(0x1013_5570, 7); movsx(eax, memw[ss, ebp - 148]);        /* movsx eax, word [ebp-0x94] */
            ii(0x1013_5577, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_5579, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_557b, 6); imul(eax, eax, 0x3100);                 /* imul eax, eax, 0x3100 */
            ii(0x1013_5581, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x1013_5584, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x1013_558a, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
        l_0x1013_5590:
            ii(0x1013_5590, 7); add(memd[ss, ebp - 156], -1 /* 0xff */); /* add dword [ebp-0x9c], 0xffffffff */
            ii(0x1013_5597, 8); cmp(memw[ss, ebp - 156], 0);            /* cmp word [ebp-0x9c], 0x0 */
            ii(0x1013_559f, 2); if(jz(0x1013_55d3, 0x32)) goto l_0x1013_55d3; /* jz 0x101355d3 */
            ii(0x1013_55a1, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_55a8, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_55ab, 7); mov(edx, memd[ds, eax + ebp - 144]);    /* mov edx, [eax+ebp-0x90] */
            ii(0x1013_55b2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_55b5, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_55bc, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_55bf, 7); mov(eax, memd[ds, eax + ebp - 146]);    /* mov eax, [eax+ebp-0x92] */
            ii(0x1013_55c6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_55c9, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_55cc, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_55ce, 3); add(memd[ss, ebp - 96], eax);           /* add [ebp-0x60], eax */
            ii(0x1013_55d1, 2); jmp(0x1013_5590, -0x43); goto l_0x1013_5590; /* jmp 0x10135590 */
        l_0x1013_55d3:
            ii(0x1013_55d3, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_55d8, 3); mov(edx, memd[ss, ebp - 96]);           /* mov edx, [ebp-0x60] */
            ii(0x1013_55db, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_55de, 5); call(Definitions.my_fseek, -0x4_618e);  /* call 0x100ef455 */
            ii(0x1013_55e3, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x1013_55e9, 1); dec(eax);                               /* dec eax */
            ii(0x1013_55ea, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
            ii(0x1013_55f0, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_55f7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_55fa, 8); mov(ax, memw[ds, eax + ebp - 144]);     /* mov ax, [eax+ebp-0x90] */
            ii(0x1013_5602, 6); mov(memw[ds, 0x101c_8172], ax);         /* mov [0x101c8172], ax */
            ii(0x1013_5608, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_560f, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_5612, 8); mov(ax, memw[ds, eax + ebp - 142]);     /* mov ax, [eax+ebp-0x8e] */
            ii(0x1013_561a, 6); mov(memw[ds, 0x101c_8174], ax);         /* mov [0x101c8174], ax */
            ii(0x1013_5620, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1013_5626, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_5629, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1013_562e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_5631, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_5634, 3); mov(memd[ss, ebp - 96], edx);           /* mov [ebp-0x60], edx */
            ii(0x1013_5637, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x1013_563a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_563c, 5); call(Definitions.sys_new_arr, 0x3_09cf); /* call 0x10166010 */
            ii(0x1013_5641, 5); mov(memd[ds, 0x101c_9450], eax);        /* mov [0x101c9450], eax */
            ii(0x1013_5646, 7); cmp(memd[ds, 0x101c_9450], 0);          /* cmp dword [0x101c9450], 0x0 */
            ii(0x1013_564d, 2); if(jnz(0x1013_5659, 0xa)) goto l_0x1013_5659; /* jnz 0x10135659 */
            ii(0x1013_564f, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x1013_5654, 5); call(0x100e_f3a0, -0x4_62b9);           /* call 0x100ef3a0 */
        l_0x1013_5659:
            ii(0x1013_5659, 3); shl(memd[ss, ebp - 96], 1);             /* shl dword [ebp-0x60], 1 */
            ii(0x1013_565c, 10); mov(memd[ss, ebp - 164], 0);           /* mov dword [ebp-0xa4], 0x0 */
            ii(0x1013_5666, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x1013_5669, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1013_566c, 6); mov(memd[ss, ebp - 168], eax);          /* mov [ebp-0xa8], eax */
            ii(0x1013_5672, 5); mov(eax, memd[ds, 0x101c_9450]);        /* mov eax, [0x101c9450] */
            ii(0x1013_5677, 6); mov(memd[ss, ebp - 172], eax);          /* mov [ebp-0xac], eax */
        l_0x1013_567d:
            ii(0x1013_567d, 6); mov(eax, memd[ss, ebp - 164]);          /* mov eax, [ebp-0xa4] */
            ii(0x1013_5683, 3); cmp(eax, memd[ss, ebp - 96]);           /* cmp eax, [ebp-0x60] */
            ii(0x1013_5686, 6); if(jz(0x1013_5706, 0x7a)) goto l_0x1013_5706; /* jz 0x10135706 */
            ii(0x1013_568c, 3); mov(edx, memd[ss, ebp - 96]);           /* mov edx, [ebp-0x60] */
            ii(0x1013_568f, 6); sub(edx, memd[ss, ebp - 164]);          /* sub edx, [ebp-0xa4] */
            ii(0x1013_5695, 6); mov(eax, memd[ss, ebp - 168]);          /* mov eax, [ebp-0xa8] */
            ii(0x1013_569b, 5); call(Definitions.my_min, -0xa_bf1c);    /* call 0x10089784 */
            ii(0x1013_56a0, 6); mov(memd[ss, ebp - 168], eax);          /* mov [ebp-0xa8], eax */
            ii(0x1013_56a6, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_56a9, 6); mov(ebx, memd[ss, ebp - 168]);          /* mov ebx, [ebp-0xa8] */
            ii(0x1013_56af, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_56b4, 6); mov(eax, memd[ss, ebp - 172]);          /* mov eax, [ebp-0xac] */
            ii(0x1013_56ba, 6); add(eax, memd[ss, ebp - 164]);          /* add eax, [ebp-0xa4] */
            ii(0x1013_56c0, 5); call(Definitions.my_fread, -0x4_6236);  /* call 0x100ef48f */
            ii(0x1013_56c5, 6); cmp(eax, memd[ss, ebp - 168]);          /* cmp eax, [ebp-0xa8] */
            ii(0x1013_56cb, 2); if(jz(0x1013_56d7, 0xa)) goto l_0x1013_56d7; /* jz 0x101356d7 */
            ii(0x1013_56cd, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_56d2, 5); call(0x100e_f3a0, -0x4_6337);           /* call 0x100ef3a0 */
        l_0x1013_56d7:
            ii(0x1013_56d7, 6); mov(eax, memd[ss, ebp - 168]);          /* mov eax, [ebp-0xa8] */
            ii(0x1013_56dd, 6); add(memd[ss, ebp - 164], eax);          /* add [ebp-0xa4], eax */
            ii(0x1013_56e3, 7); imul(edx, memd[ss, ebp - 164], 0x14);   /* imul edx, [ebp-0xa4], 0x14 */
            ii(0x1013_56ea, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_56ec, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_56ef, 3); idiv(memd[ss, ebp - 96]);               /* idiv dword [ebp-0x60] */
            ii(0x1013_56f2, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_56f5, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_56f9, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1013_56fc, 5); call(0x1013_69e9, 0x12e8);              /* call 0x101369e9 */
            ii(0x1013_5701, 5); jmp(0x1013_567d, -0x89); goto l_0x1013_567d; /* jmp 0x1013567d */
        l_0x1013_5706:
            ii(0x1013_5706, 7); mov(memd[ss, ebp - 96], 0);             /* mov dword [ebp-0x60], 0x0 */
            ii(0x1013_570d, 3); mov(eax, memd[ss, ebp - 89]);           /* mov eax, [ebp-0x59] */
            ii(0x1013_5710, 6); sub(eax, memd[ss, ebp - 148]);          /* sub eax, [ebp-0x94] */
            ii(0x1013_5716, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
        l_0x1013_571c:
            ii(0x1013_571c, 6); dec(memd[ss, ebp - 156]);               /* dec dword [ebp-0x9c] */
            ii(0x1013_5722, 8); cmp(memw[ss, ebp - 156], -1 /* 0xff */); /* cmp word [ebp-0x9c], 0xffff */
            ii(0x1013_572a, 2); if(jz(0x1013_5770, 0x44)) goto l_0x1013_5770; /* jz 0x10135770 */
            ii(0x1013_572c, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5733, 7); movsx(eax, memw[ss, ebp - 148]);        /* movsx eax, word [ebp-0x94] */
            ii(0x1013_573a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_573c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_573f, 7); mov(ebx, memd[ds, eax + ebp - 144]);    /* mov ebx, [eax+ebp-0x90] */
            ii(0x1013_5746, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1013_5749, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5750, 7); movsx(eax, memw[ss, ebp - 148]);        /* movsx eax, word [ebp-0x94] */
            ii(0x1013_5757, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_5759, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_575c, 7); mov(eax, memd[ds, eax + ebp - 146]);    /* mov eax, [eax+ebp-0x92] */
            ii(0x1013_5763, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_5766, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1013_5769, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_576b, 3); add(memd[ss, ebp - 96], eax);           /* add [ebp-0x60], eax */
            ii(0x1013_576e, 2); jmp(0x1013_571c, -0x54); goto l_0x1013_571c; /* jmp 0x1013571c */
        l_0x1013_5770:
            ii(0x1013_5770, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_5775, 3); mov(edx, memd[ss, ebp - 96]);           /* mov edx, [ebp-0x60] */
            ii(0x1013_5778, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_577b, 5); call(Definitions.my_fseek, -0x4_632b);  /* call 0x100ef455 */
            ii(0x1013_5780, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_5783, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1013_5788, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_578d, 5); mov(eax, 0x101c_946e);                  /* mov eax, 0x101c946e */
            ii(0x1013_5792, 5); call(Definitions.my_fread, -0x4_6308);  /* call 0x100ef48f */
            ii(0x1013_5797, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1013_579a, 2); if(jz(0x1013_57a6, 0xa)) goto l_0x1013_57a6; /* jz 0x101357a6 */
            ii(0x1013_579c, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_57a1, 5); call(0x100e_f3a0, -0x4_6406);           /* call 0x100ef3a0 */
        l_0x1013_57a6:
            ii(0x1013_57a6, 3); lea(edx, memd[ss, ebp - 80]);           /* lea edx, [ebp-0x50] */
            ii(0x1013_57a9, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_57ac, 5); call(0x1013_4fce, -0x7e3);              /* call 0x10134fce */
            ii(0x1013_57b1, 2); test(al, al);                           /* test al, al */
            ii(0x1013_57b3, 2); if(jnz(0x1013_57bf, 0xa)) goto l_0x1013_57bf; /* jnz 0x101357bf */
            ii(0x1013_57b5, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_57ba, 5); call(0x100e_f3a0, -0x4_641f);           /* call 0x100ef3a0 */
        l_0x1013_57bf:
            ii(0x1013_57bf, 7); mov(memd[ss, ebp - 20], 0x46);          /* mov dword [ebp-0x14], 0x46 */
            ii(0x1013_57c6, 5); mov(eax, 0x300);                        /* mov eax, 0x300 */
            ii(0x1013_57cb, 5); call(Definitions.sys_new_arr, 0x3_0840); /* call 0x10166010 */
            ii(0x1013_57d0, 6); mov(memd[ss, ebp - 176], eax);          /* mov [ebp-0xb0], eax */
            ii(0x1013_57d6, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_57d9, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x1013_57de, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_57e3, 6); mov(eax, memd[ss, ebp - 176]);          /* mov eax, [ebp-0xb0] */
            ii(0x1013_57e9, 5); call(Definitions.my_fread, -0x4_635f);  /* call 0x100ef48f */
            ii(0x1013_57ee, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x1013_57f3, 2); if(jz(0x1013_57ff, 0xa)) goto l_0x1013_57ff; /* jz 0x101357ff */
            ii(0x1013_57f5, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_57fa, 5); call(0x100e_f3a0, -0x4_645f);           /* call 0x100ef3a0 */
        l_0x1013_57ff:
            ii(0x1013_57ff, 10); mov(memd[ss, ebp - 156], 0xc0);        /* mov dword [ebp-0x9c], 0xc0 */
            ii(0x1013_5809, 2); jmp(0x1013_5817, 0xc); goto l_0x1013_5817; /* jmp 0x10135817 */
        l_0x1013_580b:
            ii(0x1013_580b, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x1013_5811, 6); inc(memd[ss, ebp - 156]);               /* inc dword [ebp-0x9c] */
        l_0x1013_5817:
            ii(0x1013_5817, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_581e, 5); cmp(eax, 0x1e0);                        /* cmp eax, 0x1e0 */
            ii(0x1013_5823, 2); if(jge(0x1013_5851, 0x2c)) goto l_0x1013_5851; /* jge 0x10135851 */
            ii(0x1013_5825, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_582c, 6); add(eax, memd[ss, ebp - 176]);          /* add eax, [ebp-0xb0] */
            ii(0x1013_5832, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_5834, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_5839, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1013_583c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1013_583e, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5845, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_584b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_584d, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
            ii(0x1013_584f, 2); jmp(0x1013_580b, -0x46); goto l_0x1013_580b; /* jmp 0x1013580b */
        l_0x1013_5851:
            ii(0x1013_5851, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_5856, 5); call(Definitions.sys_display_apply_palette, 0x3_7361); /* call 0x1016cbbc */
            ii(0x1013_585b, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_5860, 5); call(/* sys */ 0x1016_d2cc, 0x3_7a67);  /* call 0x1016d2cc */
            ii(0x1013_5865, 4); add(memd[ss, ebp - 20], 3);             /* add dword [ebp-0x14], 0x3 */
            ii(0x1013_5869, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_586d, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1013_5870, 5); call(0x1013_69e9, 0x1174);              /* call 0x101369e9 */
            ii(0x1013_5875, 6); mov(eax, memd[ss, ebp - 176]);          /* mov eax, [ebp-0xb0] */
            ii(0x1013_587b, 5); call(Definitions.sys_delete, 0x3_06e4); /* call 0x10165f64 */
            ii(0x1013_5880, 5); mov(eax, memd[ds, 0x101b_d358]);        /* mov eax, [0x101bd358] */
            ii(0x1013_5885, 6); mov(memd[ss, ebp - 180], eax);          /* mov [ebp-0xb4], eax */
            ii(0x1013_588b, 5); mov(eax, memd[ds, 0x101c_946c]);        /* mov eax, [0x101c946c] */
            ii(0x1013_5890, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_5893, 5); call(Definitions.sys_new_arr, 0x3_0778); /* call 0x10166010 */
            ii(0x1013_5898, 6); mov(memd[ss, ebp - 176], eax);          /* mov [ebp-0xb0], eax */
            ii(0x1013_589e, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1013_58a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_58a6, 6); mov(edx, memd[ds, 0x101c_8172]);        /* mov edx, [0x101c8172] */
            ii(0x1013_58ac, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_58af, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_58b2, 5); call(Definitions.sys_new_arr, 0x3_0759); /* call 0x10166010 */
            ii(0x1013_58b7, 5); mov(memd[ds, 0x101c_9454], eax);        /* mov [0x101c9454], eax */
            ii(0x1013_58bc, 3); mov(ecx, memd[ss, ebp - 16]);           /* mov ecx, [ebp-0x10] */
            ii(0x1013_58bf, 6); mov(ebx, memd[ds, 0x101c_946c]);        /* mov ebx, [0x101c946c] */
            ii(0x1013_58c5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1013_58c8, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_58cd, 6); mov(eax, memd[ss, ebp - 176]);          /* mov eax, [ebp-0xb0] */
            ii(0x1013_58d3, 5); call(Definitions.my_fread, -0x4_6449);  /* call 0x100ef48f */
            ii(0x1013_58d8, 6); mov(edx, memd[ds, 0x101c_946c]);        /* mov edx, [0x101c946c] */
            ii(0x1013_58de, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_58e1, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1013_58e3, 2); if(jz(0x1013_58ef, 0xa)) goto l_0x1013_58ef; /* jz 0x101358ef */
            ii(0x1013_58e5, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_58ea, 5); call(0x100e_f3a0, -0x4_654f);           /* call 0x100ef3a0 */
        l_0x1013_58ef:
            ii(0x1013_58ef, 10); mov(memd[ss, ebp - 156], 0);           /* mov dword [ebp-0x9c], 0x0 */
            ii(0x1013_58f9, 2); jmp(0x1013_5907, 0xc); goto l_0x1013_5907; /* jmp 0x10135907 */
        l_0x1013_58fb:
            ii(0x1013_58fb, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x1013_5901, 6); inc(memd[ss, ebp - 156]);               /* inc dword [ebp-0x9c] */
        l_0x1013_5907:
            ii(0x1013_5907, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x1013_590d, 7); cmp(ax, memw[ds, 0x101c_946e]);         /* cmp ax, [0x101c946e] */
            ii(0x1013_5914, 2); if(jge(0x1013_5942, 0x2c)) goto l_0x1013_5942; /* jge 0x10135942 */
            ii(0x1013_5916, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_591d, 6); add(eax, memd[ss, ebp - 176]);          /* add eax, [ebp-0xb0] */
            ii(0x1013_5923, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_5925, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_592a, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5931, 6); add(edx, memd[ss, ebp - 176]);          /* add edx, [ebp-0xb0] */
            ii(0x1013_5937, 7); mov(al, memb[ds, eax + ebp - 180]);     /* mov al, [eax+ebp-0xb4] */
            ii(0x1013_593e, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1013_5940, 2); jmp(0x1013_58fb, -0x47); goto l_0x1013_58fb; /* jmp 0x101358fb */
        l_0x1013_5942:
            ii(0x1013_5942, 10); mov(memd[ss, ebp - 156], 0);           /* mov dword [ebp-0x9c], 0x0 */
            ii(0x1013_594c, 2); jmp(0x1013_595a, 0xc); goto l_0x1013_595a; /* jmp 0x1013595a */
        l_0x1013_594e:
            ii(0x1013_594e, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x1013_5954, 6); inc(memd[ss, ebp - 156]);               /* inc dword [ebp-0x9c] */
        l_0x1013_595a:
            ii(0x1013_595a, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1013_5960, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_5963, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1013_5968, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_596b, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_596e, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5975, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_5977, 2); if(jge(0x1013_59a8, 0x2f)) goto l_0x1013_59a8; /* jge 0x101359a8 */
            ii(0x1013_5979, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5980, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_5982, 6); mov(edx, memd[ds, 0x101c_9450]);        /* mov edx, [0x101c9450] */
            ii(0x1013_5988, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_598a, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_598d, 6); add(eax, memd[ss, ebp - 176]);          /* add eax, [ebp-0xb0] */
            ii(0x1013_5993, 7); movsx(ebx, memw[ss, ebp - 156]);        /* movsx ebx, word [ebp-0x9c] */
            ii(0x1013_599a, 6); mov(edx, memd[ds, 0x101c_9454]);        /* mov edx, [0x101c9454] */
            ii(0x1013_59a0, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1013_59a2, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_59a4, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1013_59a6, 2); jmp(0x1013_594e, -0x5a); goto l_0x1013_594e; /* jmp 0x1013594e */
        l_0x1013_59a8:
            ii(0x1013_59a8, 6); mov(eax, memd[ss, ebp - 176]);          /* mov eax, [ebp-0xb0] */
            ii(0x1013_59ae, 5); call(Definitions.sys_delete, 0x3_05b1); /* call 0x10165f64 */
            ii(0x1013_59b3, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_59b6, 5); call(Definitions.sys_fclose, 0x3_c6ae); /* call 0x10172069 */
            ii(0x1013_59bb, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1013_59c1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_59c4, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1013_59c9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_59cc, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_59cf, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_59d1, 5); call(Definitions.sys_new_arr, 0x3_063a); /* call 0x10166010 */
            ii(0x1013_59d6, 5); mov(memd[ds, 0x101c_811c], eax);        /* mov [0x101c811c], eax */
            ii(0x1013_59db, 10); mov(memd[ss, ebp - 156], 0);           /* mov dword [ebp-0x9c], 0x0 */
            ii(0x1013_59e5, 2); jmp(0x1013_59f3, 0xc); goto l_0x1013_59f3; /* jmp 0x101359f3 */
        l_0x1013_59e7:
            ii(0x1013_59e7, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x1013_59ed, 6); inc(memd[ss, ebp - 156]);               /* inc dword [ebp-0x9c] */
        l_0x1013_59f3:
            ii(0x1013_59f3, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1013_59f9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_59fc, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1013_5a01, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_5a04, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_5a07, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5a0e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_5a10, 2); if(jge(0x1013_5a2b, 0x19)) goto l_0x1013_5a2b; /* jge 0x10135a2b */
            ii(0x1013_5a12, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5a19, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_5a1b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_5a1d, 5); mov(eax, memd[ds, 0x101c_811c]);        /* mov eax, [0x101c811c] */
            ii(0x1013_5a22, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_5a24, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1013_5a29, 2); jmp(0x1013_59e7, -0x44); goto l_0x1013_59e7; /* jmp 0x101359e7 */
        l_0x1013_5a2b:
            ii(0x1013_5a2b, 4); add(memd[ss, ebp - 20], 3);             /* add dword [ebp-0x14], 0x3 */
            ii(0x1013_5a2f, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_5a33, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1013_5a36, 5); call(0x1013_69e9, 0xfae);               /* call 0x101369e9 */
            ii(0x1013_5a3b, 6); mov(ecx, memd[ds, 0x101c_70b4]);        /* mov ecx, [0x101c70b4] */
            ii(0x1013_5a41, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5a43, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5a45, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5a4a, 5); call(0x1013_4d10, -0xd3f);              /* call 0x10134d10 */
            ii(0x1013_5a4f, 6); mov(ecx, memd[ds, 0x101c_70b8]);        /* mov ecx, [0x101c70b8] */
            ii(0x1013_5a55, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5a57, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5a5c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5a5e, 5); call(0x1013_4d10, -0xd53);              /* call 0x10134d10 */
            ii(0x1013_5a63, 6); mov(ecx, memd[ds, 0x101c_70bc]);        /* mov ecx, [0x101c70bc] */
            ii(0x1013_5a69, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5a6e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5a70, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5a72, 5); call(0x1013_4d10, -0xd67);              /* call 0x10134d10 */
            ii(0x1013_5a77, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5a79, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1013_5a7c, 5); add(eax, 0x76e);                        /* add eax, 0x76e */
            ii(0x1013_5a81, 6); mov(memd[ss, ebp - 184], eax);          /* mov [ebp-0xb8], eax */
            ii(0x1013_5a87, 5); jmp(0x1013_5bad, 0x121); goto l_0x1013_5bad; /* jmp 0x10135bad */
        l_0x1013_5a8c:
            ii(0x1013_5a8c, 6); mov(ecx, memd[ds, 0x101c_70c0]);        /* mov ecx, [0x101c70c0] */
            ii(0x1013_5a92, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5a94, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5a96, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5a9b, 5); call(0x1013_4e59, -0xc47);              /* call 0x10134e59 */
            ii(0x1013_5aa0, 6); mov(ecx, memd[ds, 0x101c_70c8]);        /* mov ecx, [0x101c70c8] */
            ii(0x1013_5aa6, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5aab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5aad, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5aaf, 5); call(0x1013_4e59, -0xc5b);              /* call 0x10134e59 */
            ii(0x1013_5ab4, 6); mov(ecx, memd[ds, 0x101c_70c4]);        /* mov ecx, [0x101c70c4] */
            ii(0x1013_5aba, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5abc, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5ac1, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5ac6, 5); call(0x1013_4e59, -0xc72);              /* call 0x10134e59 */
            ii(0x1013_5acb, 5); jmp(0x1013_5c01, 0x131); goto l_0x1013_5c01; /* jmp 0x10135c01 */
        l_0x1013_5ad0:
            ii(0x1013_5ad0, 6); mov(ecx, memd[ds, 0x101c_70c0]);        /* mov ecx, [0x101c70c0] */
            ii(0x1013_5ad6, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5adb, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5ae0, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5ae5, 5); call(0x1013_4e59, -0xc91);              /* call 0x10134e59 */
            ii(0x1013_5aea, 6); mov(ecx, memd[ds, 0x101c_70c8]);        /* mov ecx, [0x101c70c8] */
            ii(0x1013_5af0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5af2, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5af7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5af9, 5); call(0x1013_4e59, -0xca5);              /* call 0x10134e59 */
            ii(0x1013_5afe, 6); mov(ecx, memd[ds, 0x101c_70c4]);        /* mov ecx, [0x101c70c4] */
            ii(0x1013_5b04, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5b06, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5b0b, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5b10, 5); call(0x1013_4e59, -0xcbc);              /* call 0x10134e59 */
            ii(0x1013_5b15, 5); jmp(0x1013_5c01, 0xe7); goto l_0x1013_5c01; /* jmp 0x10135c01 */
        l_0x1013_5b1a:
            ii(0x1013_5b1a, 6); mov(ecx, memd[ds, 0x101c_70c0]);        /* mov ecx, [0x101c70c0] */
            ii(0x1013_5b20, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5b25, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5b2a, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5b2f, 5); call(0x1013_4e59, -0xcdb);              /* call 0x10134e59 */
            ii(0x1013_5b34, 6); mov(ecx, memd[ds, 0x101c_70c8]);        /* mov ecx, [0x101c70c8] */
            ii(0x1013_5b3a, 5); mov(ebx, 0x1f);                         /* mov ebx, 0x1f */
            ii(0x1013_5b3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5b41, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5b43, 5); call(0x1013_4e59, -0xcef);              /* call 0x10134e59 */
            ii(0x1013_5b48, 6); mov(ecx, memd[ds, 0x101c_70c4]);        /* mov ecx, [0x101c70c4] */
            ii(0x1013_5b4e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5b50, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5b55, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5b5a, 5); call(0x1013_4e59, -0xd06);              /* call 0x10134e59 */
            ii(0x1013_5b5f, 5); jmp(0x1013_5c01, 0x9d); goto l_0x1013_5c01; /* jmp 0x10135c01 */
        l_0x1013_5b64:
            ii(0x1013_5b64, 6); mov(ecx, memd[ds, 0x101c_70c0]);        /* mov ecx, [0x101c70c0] */
            ii(0x1013_5b6a, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5b6f, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5b74, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5b79, 5); call(0x1013_4e59, -0xd25);              /* call 0x10134e59 */
            ii(0x1013_5b7e, 6); mov(ecx, memd[ds, 0x101c_70c8]);        /* mov ecx, [0x101c70c8] */
            ii(0x1013_5b84, 5); mov(ebx, 0x1f);                         /* mov ebx, 0x1f */
            ii(0x1013_5b89, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5b8b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5b8d, 5); call(0x1013_4e59, -0xd39);              /* call 0x10134e59 */
            ii(0x1013_5b92, 6); mov(ecx, memd[ds, 0x101c_70c4]);        /* mov ecx, [0x101c70c4] */
            ii(0x1013_5b98, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_5b9a, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1013_5b9f, 5); mov(eax, 0x3f);                         /* mov eax, 0x3f */
            ii(0x1013_5ba4, 5); call(0x1013_4e59, -0xd50);              /* call 0x10134e59 */
            ii(0x1013_5ba9, 2); jmp(0x1013_5c01, 0x56); goto l_0x1013_5c01; /* jmp 0x10135c01 */
        l_0x1013_5bab:
            ii(0x1013_5bab, 2); jmp(0x1013_5c01, 0x54); goto l_0x1013_5c01; /* jmp 0x10135c01 */
        l_0x1013_5bad:
            ii(0x1013_5bad, 10); cmp(memd[ss, ebp - 184], 0x774);       /* cmp dword [ebp-0xb8], 0x774 */
            ii(0x1013_5bb7, 2); if(jb(0x1013_5bef, 0x36)) goto l_0x1013_5bef; /* jb 0x10135bef */
            ii(0x1013_5bb9, 10); cmp(memd[ss, ebp - 184], 0x779);       /* cmp dword [ebp-0xb8], 0x779 */
            ii(0x1013_5bc3, 6); if(jbe(0x1013_5ad0, -0xf9)) goto l_0x1013_5ad0; /* jbe 0x10135ad0 */
            ii(0x1013_5bc9, 10); cmp(memd[ss, ebp - 184], 0x77f);       /* cmp dword [ebp-0xb8], 0x77f */
            ii(0x1013_5bd3, 6); if(jbe(0x1013_5b1a, -0xbf)) goto l_0x1013_5b1a; /* jbe 0x10135b1a */
            ii(0x1013_5bd9, 10); cmp(memd[ss, ebp - 184], 0x785);       /* cmp dword [ebp-0xb8], 0x785 */
            ii(0x1013_5be3, 6); if(jbe(0x1013_5b64, -0x85)) goto l_0x1013_5b64; /* jbe 0x10135b64 */
            ii(0x1013_5be9, 2); jmp(0x1013_5bab, -0x40); goto l_0x1013_5bab; /* jmp 0x10135bab */
        //  ii(0x1013_5beb, 2); jmp(0x1013_5bab, -0x42); goto l_0x1013_5bab; /* jmp 0x10135bab */
        //  ii(0x1013_5bed, 2); jmp(0x1013_5bab, -0x44); goto l_0x1013_5bab; /* jmp 0x10135bab */
        l_0x1013_5bef:
            ii(0x1013_5bef, 10); cmp(memd[ss, ebp - 184], 0x76e);       /* cmp dword [ebp-0xb8], 0x76e */
            ii(0x1013_5bf9, 6); if(jae(0x1013_5a8c, -0x173)) goto l_0x1013_5a8c; /* jae 0x10135a8c */
            ii(0x1013_5bff, 2); jmp(0x1013_5bab, -0x56); goto l_0x1013_5bab; /* jmp 0x10135bab */
        l_0x1013_5c01:
            ii(0x1013_5c01, 5); mov(eax, memd[ds, 0x101c_70cc]);        /* mov eax, [0x101c70cc] */
            ii(0x1013_5c06, 6); mov(memd[ss, ebp - 188], eax);          /* mov [ebp-0xbc], eax */
            ii(0x1013_5c0c, 10); mov(memd[ss, ebp - 156], 0);           /* mov dword [ebp-0x9c], 0x0 */
            ii(0x1013_5c16, 2); jmp(0x1013_5c1f, 7); goto l_0x1013_5c1f; /* jmp 0x10135c1f */
        l_0x1013_5c18:
            ii(0x1013_5c18, 7); add(memd[ss, ebp - 156], 3);            /* add dword [ebp-0x9c], 0x3 */
        l_0x1013_5c1f:
            ii(0x1013_5c1f, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5c26, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x1013_5c2b, 6); if(jge(0x1013_5d1f, 0xee)) goto l_0x1013_5d1f; /* jge 0x10135d1f */
            ii(0x1013_5c31, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5c38, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_5c3d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_5c3f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5c41, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1013_5c43, 6); mov(memd[ss, ebp - 192], eax);          /* mov [ebp-0xc0], eax */
            ii(0x1013_5c49, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5c50, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_5c56, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_5c58, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5c5a, 3); mov(al, memb[ds, edx + 1]);             /* mov al, [edx+0x1] */
            ii(0x1013_5c5d, 6); mov(memd[ss, ebp - 196], eax);          /* mov [ebp-0xc4], eax */
            ii(0x1013_5c63, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5c6a, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_5c6f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_5c71, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5c73, 3); mov(al, memb[ds, edx + 2]);             /* mov al, [edx+0x2] */
            ii(0x1013_5c76, 6); mov(memd[ss, ebp - 200], eax);          /* mov [ebp-0xc8], eax */
            ii(0x1013_5c7c, 5); mov(edx, 7);                            /* mov edx, 0x7 */
            ii(0x1013_5c81, 7); movsx(eax, memw[ss, ebp - 192]);        /* movsx eax, word [ebp-0xc0] */
            ii(0x1013_5c88, 5); call(0x1007_6e7c, -0xb_ee11);           /* call 0x10076e7c */
            ii(0x1013_5c8d, 3); imul(edx, eax, 0x1f);                   /* imul edx, eax, 0x1f */
            ii(0x1013_5c90, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5c95, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5c97, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5c9a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_5c9c, 6); mov(memd[ss, ebp - 192], eax);          /* mov [ebp-0xc0], eax */
            ii(0x1013_5ca2, 5); mov(edx, 7);                            /* mov edx, 0x7 */
            ii(0x1013_5ca7, 7); movsx(eax, memw[ss, ebp - 196]);        /* movsx eax, word [ebp-0xc4] */
            ii(0x1013_5cae, 5); call(0x1007_6e7c, -0xb_ee37);           /* call 0x10076e7c */
            ii(0x1013_5cb3, 3); imul(edx, eax, 0x1f);                   /* imul edx, eax, 0x1f */
            ii(0x1013_5cb6, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5cbb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5cbd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5cc0, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_5cc2, 6); mov(memd[ss, ebp - 196], eax);          /* mov [ebp-0xc4], eax */
            ii(0x1013_5cc8, 5); mov(edx, 7);                            /* mov edx, 0x7 */
            ii(0x1013_5ccd, 7); movsx(eax, memw[ss, ebp - 200]);        /* movsx eax, word [ebp-0xc8] */
            ii(0x1013_5cd4, 5); call(0x1007_6e7c, -0xb_ee5d);           /* call 0x10076e7c */
            ii(0x1013_5cd9, 3); imul(edx, eax, 0x1f);                   /* imul edx, eax, 0x1f */
            ii(0x1013_5cdc, 5); mov(ebx, 0x3f);                         /* mov ebx, 0x3f */
            ii(0x1013_5ce1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5ce3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5ce6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_5ce8, 6); mov(memd[ss, ebp - 200], eax);          /* mov [ebp-0xc8], eax */
            ii(0x1013_5cee, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_5cf0, 7); movsx(ebx, memw[ss, ebp - 200]);        /* movsx ebx, word [ebp-0xc8] */
            ii(0x1013_5cf7, 7); movsx(edx, memw[ss, ebp - 196]);        /* movsx edx, word [ebp-0xc4] */
            ii(0x1013_5cfe, 7); movsx(eax, memw[ss, ebp - 192]);        /* movsx eax, word [ebp-0xc0] */
            ii(0x1013_5d05, 5); call(0x1013_3a88, -0x2282);             /* call 0x10133a88 */
            ii(0x1013_5d0a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1013_5d0c, 6); mov(eax, memd[ss, ebp - 188]);          /* mov eax, [ebp-0xbc] */
            ii(0x1013_5d12, 6); inc(memd[ss, ebp - 188]);               /* inc dword [ebp-0xbc] */
            ii(0x1013_5d18, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1013_5d1a, 5); jmp(0x1013_5c18, -0x107); goto l_0x1013_5c18; /* jmp 0x10135c18 */
        l_0x1013_5d1f:
            ii(0x1013_5d1f, 4); add(memd[ss, ebp - 20], 3);             /* add dword [ebp-0x14], 0x3 */
            ii(0x1013_5d23, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_5d27, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1013_5d2a, 5); call(0x1013_69e9, 0xcba);               /* call 0x101369e9 */
            ii(0x1013_5d2f, 5); mov(eax, memd[ds, 0x101c_945c]);        /* mov eax, [0x101c945c] */
            ii(0x1013_5d34, 6); mov(memd[ss, ebp - 188], eax);          /* mov [ebp-0xbc], eax */
            ii(0x1013_5d3a, 10); mov(memd[ss, ebp - 156], 0);           /* mov dword [ebp-0x9c], 0x0 */
            ii(0x1013_5d44, 2); jmp(0x1013_5d4d, 7); goto l_0x1013_5d4d; /* jmp 0x10135d4d */
        l_0x1013_5d46:
            ii(0x1013_5d46, 7); add(memd[ss, ebp - 156], 0x20);         /* add dword [ebp-0x9c], 0x20 */
        l_0x1013_5d4d:
            ii(0x1013_5d4d, 7); movsx(eax, memw[ss, ebp - 156]);        /* movsx eax, word [ebp-0x9c] */
            ii(0x1013_5d54, 5); cmp(eax, 0xe0);                         /* cmp eax, 0xe0 */
            ii(0x1013_5d59, 6); if(jge(0x1013_5e79, 0x11a)) goto l_0x1013_5e79; /* jge 0x10135e79 */
            ii(0x1013_5d5f, 10); mov(memd[ss, ebp - 204], 0);           /* mov dword [ebp-0xcc], 0x0 */
            ii(0x1013_5d69, 2); jmp(0x1013_5d72, 7); goto l_0x1013_5d72; /* jmp 0x10135d72 */
        l_0x1013_5d6b:
            ii(0x1013_5d6b, 7); add(memd[ss, ebp - 204], 3);            /* add dword [ebp-0xcc], 0x3 */
        l_0x1013_5d72:
            ii(0x1013_5d72, 7); movsx(eax, memw[ss, ebp - 204]);        /* movsx eax, word [ebp-0xcc] */
            ii(0x1013_5d79, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x1013_5d7e, 6); if(jge(0x1013_5e64, 0xe0)) goto l_0x1013_5e64; /* jge 0x10135e64 */
            ii(0x1013_5d84, 7); movsx(eax, memw[ss, ebp - 204]);        /* movsx eax, word [ebp-0xcc] */
            ii(0x1013_5d8b, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_5d91, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_5d93, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_5d95, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_5d9a, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5da1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_5da4, 5); mov(ebx, 0xe0);                         /* mov ebx, 0xe0 */
            ii(0x1013_5da9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5dab, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5dae, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_5db0, 6); mov(memd[ss, ebp - 208], eax);          /* mov [ebp-0xd0], eax */
            ii(0x1013_5db6, 7); movsx(edx, memw[ss, ebp - 204]);        /* movsx edx, word [ebp-0xcc] */
            ii(0x1013_5dbd, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_5dc2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_5dc4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5dc6, 3); mov(al, memb[ds, edx + 1]);             /* mov al, [edx+0x1] */
            ii(0x1013_5dc9, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5dd0, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_5dd3, 5); mov(ebx, 0xe0);                         /* mov ebx, 0xe0 */
            ii(0x1013_5dd8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5dda, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5ddd, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_5ddf, 6); mov(memd[ss, ebp - 212], eax);          /* mov [ebp-0xd4], eax */
            ii(0x1013_5de5, 7); movsx(eax, memw[ss, ebp - 204]);        /* movsx eax, word [ebp-0xcc] */
            ii(0x1013_5dec, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_5df2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_5df4, 3); mov(al, memb[ds, eax + 2]);             /* mov al, [eax+0x2] */
            ii(0x1013_5df7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_5dfc, 7); movsx(edx, memw[ss, ebp - 156]);        /* movsx edx, word [ebp-0x9c] */
            ii(0x1013_5e03, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_5e06, 5); mov(ebx, 0xe0);                         /* mov ebx, 0xe0 */
            ii(0x1013_5e0b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5e0d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5e10, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_5e12, 6); mov(memd[ss, ebp - 216], eax);          /* mov [ebp-0xd8], eax */
            ii(0x1013_5e18, 7); movsx(eax, memw[ss, ebp - 204]);        /* movsx eax, word [ebp-0xcc] */
            ii(0x1013_5e1f, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1013_5e22, 2); if(jnz(0x1013_5e35, 0x11)) goto l_0x1013_5e35; /* jnz 0x10135e35 */
            ii(0x1013_5e24, 6); mov(eax, memd[ss, ebp - 188]);          /* mov eax, [ebp-0xbc] */
            ii(0x1013_5e2a, 6); inc(memd[ss, ebp - 188]);               /* inc dword [ebp-0xbc] */
            ii(0x1013_5e30, 3); mov(memb[ds, eax], 0x1f);               /* mov byte [eax], 0x1f */
            ii(0x1013_5e33, 2); jmp(0x1013_5e5f, 0x2a); goto l_0x1013_5e5f; /* jmp 0x10135e5f */
        l_0x1013_5e35:
            ii(0x1013_5e35, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_5e37, 7); movsx(ebx, memw[ss, ebp - 216]);        /* movsx ebx, word [ebp-0xd8] */
            ii(0x1013_5e3e, 7); movsx(edx, memw[ss, ebp - 212]);        /* movsx edx, word [ebp-0xd4] */
            ii(0x1013_5e45, 7); movsx(eax, memw[ss, ebp - 208]);        /* movsx eax, word [ebp-0xd0] */
            ii(0x1013_5e4c, 5); call(0x1013_3a88, -0x23c9);             /* call 0x10133a88 */
            ii(0x1013_5e51, 6); mov(edx, memd[ss, ebp - 188]);          /* mov edx, [ebp-0xbc] */
            ii(0x1013_5e57, 6); inc(memd[ss, ebp - 188]);               /* inc dword [ebp-0xbc] */
            ii(0x1013_5e5d, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
        l_0x1013_5e5f:
            ii(0x1013_5e5f, 5); jmp(0x1013_5d6b, -0xf9); goto l_0x1013_5d6b; /* jmp 0x10135d6b */
        l_0x1013_5e64:
            ii(0x1013_5e64, 4); add(memd[ss, ebp - 20], 3);             /* add dword [ebp-0x14], 0x3 */
            ii(0x1013_5e68, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_5e6c, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1013_5e6f, 5); call(0x1013_69e9, 0xb75);               /* call 0x101369e9 */
            ii(0x1013_5e74, 5); jmp(0x1013_5d46, -0x133); goto l_0x1013_5d46; /* jmp 0x10135d46 */
        l_0x1013_5e79:
            ii(0x1013_5e79, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_5e7b, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1013_5e7e, 5); call(0x1013_6942, 0xabf);               /* call 0x10136942 */
            ii(0x1013_5e83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_5e85, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_5e86, 1); pop(edi);                               /* pop edi */
            ii(0x1013_5e87, 1); pop(esi);                               /* pop esi */
            ii(0x1013_5e88, 1); pop(edx);                               /* pop edx */
            ii(0x1013_5e89, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_5e8a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_5e8b, 1); ret();                                  /* ret */
        }
    }
}
