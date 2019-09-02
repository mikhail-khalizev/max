using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_c8d0-cfb078b1")]
        public void Method_1012_c8d0()
        {
            ii(0x1012_c8d0, 5); push(0x208);                            /* push 0x208 */
            ii(0x1012_c8d5, 5); call(Definitions.sys_check_available_stack_size, 0x3_9478); /* call 0x10165d52 */
            ii(0x1012_c8da, 1); push(ebx);                              /* push ebx */
            ii(0x1012_c8db, 1); push(ecx);                              /* push ecx */
            ii(0x1012_c8dc, 1); push(edx);                              /* push edx */
            ii(0x1012_c8dd, 1); push(esi);                              /* push esi */
            ii(0x1012_c8de, 1); push(edi);                              /* push edi */
            ii(0x1012_c8df, 1); push(ebp);                              /* push ebp */
            ii(0x1012_c8e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_c8e2, 6); sub(esp, 0x1e0);                        /* sub esp, 0x1e0 */
            ii(0x1012_c8e8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_c8eb, 5); mov(edx, 0x6bb);                        /* mov edx, 0x6bb */
            ii(0x1012_c8f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c8f3, 5); call(0x100d_67d8, -0x5_6120);           /* call 0x100d67d8 */
            ii(0x1012_c8f8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_c8fb, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1012_c8fe, 6); mov(memd[ss, ebp - 340], eax);          /* mov [ebp-0x154], eax */
            ii(0x1012_c904, 5); call(0x100e_86e8, -0x4_4221);           /* call 0x100e86e8 */
            ii(0x1012_c909, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_c90c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c90f, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_c912, 5); call(0x100e_5365, -0x4_75b2);           /* call 0x100e5365 */
            ii(0x1012_c917, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x1012_c91a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_c91d, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1012_c920, 6); mov(memd[ss, ebp - 404], eax);          /* mov [ebp-0x194], eax */
            ii(0x1012_c926, 5); call(0x1008_b3ec, -0xa_153f);           /* call 0x1008b3ec */
            ii(0x1012_c92b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_c92e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c931, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1012_c934, 5); call(0x1008_b1e4, -0xa_1755);           /* call 0x1008b1e4 */
            ii(0x1012_c939, 3); sub(eax, 0x22);                         /* sub eax, 0x22 */
            ii(0x1012_c93c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_c93f, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1012_c942, 6); mov(memd[ss, ebp - 408], eax);          /* mov [ebp-0x198], eax */
            ii(0x1012_c948, 5); call(0x1013_19d0, 0x5083);              /* call 0x101319d0 */
            ii(0x1012_c94d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_c950, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c953, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_c956, 5); call(0x1013_1968, 0x500d);              /* call 0x10131968 */
            ii(0x1012_c95b, 3); sub(eax, 0x26);                         /* sub eax, 0x26 */
            ii(0x1012_c95e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_c961, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1012_c964, 6); mov(memd[ss, ebp - 412], eax);          /* mov [ebp-0x19c], eax */
            ii(0x1012_c96a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c96d, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_c970, 5); call(0x1013_1c74, 0x52ff);              /* call 0x10131c74 */
            ii(0x1012_c975, 3); sub(eax, 0x36);                         /* sub eax, 0x36 */
            ii(0x1012_c978, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_c97b, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1012_c97e, 6); mov(memd[ss, ebp - 416], eax);          /* mov [ebp-0x1a0], eax */
            ii(0x1012_c984, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c987, 7); mov(memd[ds, eax + 19], 0x101b_6bd8);   /* mov dword [eax+0x13], 0x101b6bd8 */
            ii(0x1012_c98e, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1012_c993, 1); push(eax);                              /* push eax */
            ii(0x1012_c994, 5); mov(ecx, 0x5a);                         /* mov ecx, 0x5a */
            ii(0x1012_c999, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_c99b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c99d, 6); lea(eax, memd[ss, ebp - 432]);          /* lea eax, [ebp-0x1b0] */
            ii(0x1012_c9a3, 5); call(0x1008_b148, -0xa_1860);           /* call 0x1008b148 */
            ii(0x1012_c9a8, 5); call(/* sys */ 0x1016_be34, 0x3_f487);  /* call 0x1016be34 */
            ii(0x1012_c9ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c9af, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c9b2, 5); call(0x100d_6adf, -0x5_5ed8);           /* call 0x100d6adf */
            ii(0x1012_c9b7, 6); lea(edx, memd[ss, ebp - 460]);          /* lea edx, [ebp-0x1cc] */
            ii(0x1012_c9bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_c9c0, 5); call(0x100d_6a11, -0x5_5fb4);           /* call 0x100d6a11 */
            ii(0x1012_c9c5, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1012_c9ca, 5); call(Definitions.sys_new, 0x3_9431);    /* call 0x10165e00 */
            ii(0x1012_c9cf, 6); mov(memd[ss, ebp - 392], eax);          /* mov [ebp-0x188], eax */
            ii(0x1012_c9d5, 6); mov(eax, memd[ss, ebp - 392]);          /* mov eax, [ebp-0x188] */
            ii(0x1012_c9db, 6); mov(memd[ss, ebp - 396], eax);          /* mov [ebp-0x18c], eax */
            ii(0x1012_c9e1, 7); cmp(memd[ss, ebp - 396], 0);            /* cmp dword [ebp-0x18c], 0x0 */
            ii(0x1012_c9e8, 2); if(jz(0x1012_ca1e, 0x34)) goto l_0x1012_ca1e; /* jz 0x1012ca1e */
            ii(0x1012_c9ea, 5); mov(eax, 0x1c0);                        /* mov eax, 0x1c0 */
            ii(0x1012_c9ef, 1); push(eax);                              /* push eax */
            ii(0x1012_c9f0, 5); mov(ecx, 0x1cb);                        /* mov ecx, 0x1cb */
            ii(0x1012_c9f5, 5); mov(ebx, 0x11);                         /* mov ebx, 0x11 */
            ii(0x1012_c9fa, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x1012_c9ff, 6); mov(eax, memd[ss, ebp - 392]);          /* mov eax, [ebp-0x188] */
            ii(0x1012_ca05, 5); call(0x100d_7bdc, -0x5_4e2e);           /* call 0x100d7bdc */
            ii(0x1012_ca0a, 6); mov(memd[ss, ebp - 400], eax);          /* mov [ebp-0x190], eax */
            ii(0x1012_ca10, 6); mov(eax, memd[ss, ebp - 400]);          /* mov eax, [ebp-0x190] */
            ii(0x1012_ca16, 6); mov(memd[ss, ebp - 192], eax);          /* mov [ebp-0xc0], eax */
            ii(0x1012_ca1c, 2); jmp(0x1012_ca2a, 0xc); goto l_0x1012_ca2a; /* jmp 0x1012ca2a */
        l_0x1012_ca1e:
            ii(0x1012_ca1e, 6); mov(eax, memd[ss, ebp - 396]);          /* mov eax, [ebp-0x18c] */
            ii(0x1012_ca24, 6); mov(memd[ss, ebp - 192], eax);          /* mov [ebp-0xc0], eax */
        l_0x1012_ca2a:
            ii(0x1012_ca2a, 6); mov(eax, memd[ss, ebp - 192]);          /* mov eax, [ebp-0xc0] */
            ii(0x1012_ca30, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_ca33, 6); mov(memd[ds, edx + 222], eax);          /* mov [edx+0xde], eax */
            ii(0x1012_ca39, 6); lea(edx, memd[ss, ebp - 460]);          /* lea edx, [ebp-0x1cc] */
            ii(0x1012_ca3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ca42, 6); mov(eax, memd[ds, eax + 222]);          /* mov eax, [eax+0xde] */
            ii(0x1012_ca48, 5); call(0x100d_7d74, -0x5_4cd9);           /* call 0x100d7d74 */
            ii(0x1012_ca4d, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x1012_ca52, 5); call(/* sys */ 0x1016_a24c, 0x3_d7f5);  /* call 0x1016a24c */
            ii(0x1012_ca57, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ca5a, 6); mov(eax, memd[ds, eax + 222]);          /* mov eax, [eax+0xde] */
            ii(0x1012_ca60, 5); call(0x100d_4f24, -0x5_7b41);           /* call 0x100d4f24 */
            ii(0x1012_ca65, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_ca68, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1012_ca6d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_ca6f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_ca72, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_ca74, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_ca76, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ca79, 4); mov(memw[ds, eax + 58], dx);            /* mov [eax+0x3a], dx */
            ii(0x1012_ca7d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ca80, 6); mov(eax, memd[ds, eax + 222]);          /* mov eax, [eax+0xde] */
            ii(0x1012_ca86, 5); call(0x100d_4f24, -0x5_7b67);           /* call 0x100d4f24 */
            ii(0x1012_ca8b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_ca8e, 3); sub(edx, 0x14);                         /* sub edx, 0x14 */
            ii(0x1012_ca91, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1012_ca96, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_ca98, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_ca9b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_ca9d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_ca9f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_caa2, 4); mov(memw[ds, eax + 60], dx);            /* mov [eax+0x3c], dx */
            ii(0x1012_caa6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_caa9, 6); mov(eax, memd[ds, eax + 222]);          /* mov eax, [eax+0xde] */
            ii(0x1012_caaf, 5); call(0x100d_4f24, -0x5_7b90);           /* call 0x100d4f24 */
            ii(0x1012_cab4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_cab7, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1012_cabd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_cabf, 3); sub(edx, 0xc);                          /* sub edx, 0xc */
            ii(0x1012_cac2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_cac4, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_cac7, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_cac9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_cacb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cace, 4); mov(memw[ds, eax + 62], dx);            /* mov [eax+0x3e], dx */
            ii(0x1012_cad2, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_cad7, 5); call(Definitions.sys_new, 0x3_9324);    /* call 0x10165e00 */
            ii(0x1012_cadc, 6); mov(memd[ss, ebp - 380], eax);          /* mov [ebp-0x17c], eax */
            ii(0x1012_cae2, 6); mov(eax, memd[ss, ebp - 380]);          /* mov eax, [ebp-0x17c] */
            ii(0x1012_cae8, 6); mov(memd[ss, ebp - 384], eax);          /* mov [ebp-0x180], eax */
            ii(0x1012_caee, 7); cmp(memd[ss, ebp - 384], 0);            /* cmp dword [ebp-0x180], 0x0 */
            ii(0x1012_caf5, 2); if(jz(0x1012_cb2b, 0x34)) goto l_0x1012_cb2b; /* jz 0x1012cb2b */
            ii(0x1012_caf7, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1012_cafc, 1); push(eax);                              /* push eax */
            ii(0x1012_cafd, 5); mov(ecx, 0x1fd);                        /* mov ecx, 0x1fd */
            ii(0x1012_cb02, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x1012_cb07, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x1012_cb0c, 6); mov(eax, memd[ss, ebp - 380]);          /* mov eax, [ebp-0x17c] */
            ii(0x1012_cb12, 5); call(Definitions.my_ctor_c17, -0x5_e708); /* call 0x100ce40f */
            ii(0x1012_cb17, 6); mov(memd[ss, ebp - 388], eax);          /* mov [ebp-0x184], eax */
            ii(0x1012_cb1d, 6); mov(eax, memd[ss, ebp - 388]);          /* mov eax, [ebp-0x184] */
            ii(0x1012_cb23, 6); mov(memd[ss, ebp - 188], eax);          /* mov [ebp-0xbc], eax */
            ii(0x1012_cb29, 2); jmp(0x1012_cb37, 0xc); goto l_0x1012_cb37; /* jmp 0x1012cb37 */
        l_0x1012_cb2b:
            ii(0x1012_cb2b, 6); mov(eax, memd[ss, ebp - 384]);          /* mov eax, [ebp-0x180] */
            ii(0x1012_cb31, 6); mov(memd[ss, ebp - 188], eax);          /* mov [ebp-0xbc], eax */
        l_0x1012_cb37:
            ii(0x1012_cb37, 6); mov(eax, memd[ss, ebp - 188]);          /* mov eax, [ebp-0xbc] */
            ii(0x1012_cb3d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_cb40, 6); mov(memd[ds, edx + 158], eax);          /* mov [edx+0x9e], eax */
            ii(0x1012_cb46, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_cb4b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cb4e, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_cb54, 5); call(0x100d_5194, -0x5_79c5);           /* call 0x100d5194 */
            ii(0x1012_cb59, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_cb5f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cb62, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_cb68, 5); call(0x100c_e92d, -0x5_e240);           /* call 0x100ce92d */
            ii(0x1012_cb6d, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1012_cb70, 5); call(0x100e_0ba4, -0x4_bfd1);           /* call 0x100e0ba4 */
            ii(0x1012_cb75, 1); push(eax);                              /* push eax */
            ii(0x1012_cb76, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1012_cb79, 5); call(0x100e_0bd0, -0x4_bfae);           /* call 0x100e0bd0 */
            ii(0x1012_cb7e, 1); push(eax);                              /* push eax */
            ii(0x1012_cb7f, 3); lea(eax, memd[ss, ebp - 100]);          /* lea eax, [ebp-0x64] */
            ii(0x1012_cb82, 5); call(0x100e_0bfc, -0x4_bf8b);           /* call 0x100e0bfc */
            ii(0x1012_cb87, 1); push(eax);                              /* push eax */
            ii(0x1012_cb88, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1012_cb8b, 5); call(0x100e_0c28, -0x4_bf68);           /* call 0x100e0c28 */
            ii(0x1012_cb90, 6); lea(ebx, memd[ss, ebp - 432]);          /* lea ebx, [ebp-0x1b0] */
            ii(0x1012_cb96, 5); mov(edx, StringDefinitions.Units);      /* mov edx, 0x101a8748 */
            ii(0x1012_cb9b, 3); mov(esi, memd[ss, ebp - 4]);            /* mov esi, [ebp-0x4] */
            ii(0x1012_cb9e, 6); mov(esi, memd[ds, esi + 158]);          /* mov esi, [esi+0x9e] */
            ii(0x1012_cba4, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_cba6, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_cba8, 5); call(0x100c_edcd, -0x5_dde0);           /* call 0x100cedcd */
            ii(0x1012_cbad, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_cbb0, 5); mov(edx, 0x1013_0cc5);                  /* mov edx, 0x10130cc5 */
            ii(0x1012_cbb5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cbb8, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_cbbe, 5); call(0x100c_f7ec, -0x5_d3d7);           /* call 0x100cf7ec */
            ii(0x1012_cbc3, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_cbc8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cbcb, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_cbd1, 5); call(0x100d_50d4, -0x5_7b02);           /* call 0x100d50d4 */
            ii(0x1012_cbd6, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_cbdc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cbdf, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_cbe5, 5); call(0x100c_f85c, -0x5_d38e);           /* call 0x100cf85c */
            ii(0x1012_cbea, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_cbef, 5); call(Definitions.sys_new, 0x3_920c);    /* call 0x10165e00 */
            ii(0x1012_cbf4, 6); mov(memd[ss, ebp - 368], eax);          /* mov [ebp-0x170], eax */
            ii(0x1012_cbfa, 6); mov(eax, memd[ss, ebp - 368]);          /* mov eax, [ebp-0x170] */
            ii(0x1012_cc00, 6); mov(memd[ss, ebp - 372], eax);          /* mov [ebp-0x174], eax */
            ii(0x1012_cc06, 7); cmp(memd[ss, ebp - 372], 0);            /* cmp dword [ebp-0x174], 0x0 */
            ii(0x1012_cc0d, 2); if(jz(0x1012_cc43, 0x34)) goto l_0x1012_cc43; /* jz 0x1012cc43 */
            ii(0x1012_cc0f, 5); mov(eax, 0x64);                         /* mov eax, 0x64 */
            ii(0x1012_cc14, 1); push(eax);                              /* push eax */
            ii(0x1012_cc15, 5); mov(ecx, 0x1fd);                        /* mov ecx, 0x1fd */
            ii(0x1012_cc1a, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x1012_cc1f, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x1012_cc24, 6); mov(eax, memd[ss, ebp - 368]);          /* mov eax, [ebp-0x170] */
            ii(0x1012_cc2a, 5); call(Definitions.my_ctor_c17, -0x5_e820); /* call 0x100ce40f */
            ii(0x1012_cc2f, 6); mov(memd[ss, ebp - 376], eax);          /* mov [ebp-0x178], eax */
            ii(0x1012_cc35, 6); mov(eax, memd[ss, ebp - 376]);          /* mov eax, [ebp-0x178] */
            ii(0x1012_cc3b, 6); mov(memd[ss, ebp - 184], eax);          /* mov [ebp-0xb8], eax */
            ii(0x1012_cc41, 2); jmp(0x1012_cc4f, 0xc); goto l_0x1012_cc4f; /* jmp 0x1012cc4f */
        l_0x1012_cc43:
            ii(0x1012_cc43, 6); mov(eax, memd[ss, ebp - 372]);          /* mov eax, [ebp-0x174] */
            ii(0x1012_cc49, 6); mov(memd[ss, ebp - 184], eax);          /* mov [ebp-0xb8], eax */
        l_0x1012_cc4f:
            ii(0x1012_cc4f, 6); mov(eax, memd[ss, ebp - 184]);          /* mov eax, [ebp-0xb8] */
            ii(0x1012_cc55, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_cc58, 6); mov(memd[ds, edx + 162], eax);          /* mov [edx+0xa2], eax */
            ii(0x1012_cc5e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_cc63, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cc66, 6); mov(eax, memd[ds, eax + 162]);          /* mov eax, [eax+0xa2] */
            ii(0x1012_cc6c, 5); call(0x100d_5194, -0x5_7add);           /* call 0x100d5194 */
            ii(0x1012_cc71, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_cc77, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cc7a, 6); mov(eax, memd[ds, eax + 162]);          /* mov eax, [eax+0xa2] */
            ii(0x1012_cc80, 5); call(0x100c_e92d, -0x5_e358);           /* call 0x100ce92d */
            ii(0x1012_cc85, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x1012_cc88, 5); call(0x100e_0ba4, -0x4_c0e9);           /* call 0x100e0ba4 */
            ii(0x1012_cc8d, 1); push(eax);                              /* push eax */
            ii(0x1012_cc8e, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1012_cc91, 5); call(0x100e_0bd0, -0x4_c0c6);           /* call 0x100e0bd0 */
            ii(0x1012_cc96, 1); push(eax);                              /* push eax */
            ii(0x1012_cc97, 3); lea(eax, memd[ss, ebp - 104]);          /* lea eax, [ebp-0x68] */
            ii(0x1012_cc9a, 5); call(0x100e_0bfc, -0x4_c0a3);           /* call 0x100e0bfc */
            ii(0x1012_cc9f, 1); push(eax);                              /* push eax */
            ii(0x1012_cca0, 3); lea(eax, memd[ss, ebp - 120]);          /* lea eax, [ebp-0x78] */
            ii(0x1012_cca3, 5); call(0x100e_0c28, -0x4_c080);           /* call 0x100e0c28 */
            ii(0x1012_cca8, 6); lea(ebx, memd[ss, ebp - 432]);          /* lea ebx, [ebp-0x1b0] */
            ii(0x1012_ccae, 5); mov(edx, StringDefinitions.Casualties); /* mov edx, 0x101a874e */
            ii(0x1012_ccb3, 3); mov(esi, memd[ss, ebp - 4]);            /* mov esi, [ebp-0x4] */
            ii(0x1012_ccb6, 6); mov(esi, memd[ds, esi + 162]);          /* mov esi, [esi+0xa2] */
            ii(0x1012_ccbc, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_ccbe, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_ccc0, 5); call(0x100c_edcd, -0x5_def8);           /* call 0x100cedcd */
            ii(0x1012_ccc5, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_ccc8, 5); mov(edx, 0x1013_0d0d);                  /* mov edx, 0x10130d0d */
            ii(0x1012_cccd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ccd0, 6); mov(eax, memd[ds, eax + 162]);          /* mov eax, [eax+0xa2] */
            ii(0x1012_ccd6, 5); call(0x100c_f7ec, -0x5_d4ef);           /* call 0x100cf7ec */
            ii(0x1012_ccdb, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_cce0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cce3, 6); mov(eax, memd[ds, eax + 162]);          /* mov eax, [eax+0xa2] */
            ii(0x1012_cce9, 5); call(0x100d_50d4, -0x5_7c1a);           /* call 0x100d50d4 */
            ii(0x1012_ccee, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_ccf4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ccf7, 6); mov(eax, memd[ds, eax + 162]);          /* mov eax, [eax+0xa2] */
            ii(0x1012_ccfd, 5); call(0x100c_f85c, -0x5_d4a6);           /* call 0x100cf85c */
            ii(0x1012_cd02, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_cd07, 5); call(Definitions.sys_new, 0x3_90f4);    /* call 0x10165e00 */
            ii(0x1012_cd0c, 6); mov(memd[ss, ebp - 356], eax);          /* mov [ebp-0x164], eax */
            ii(0x1012_cd12, 6); mov(eax, memd[ss, ebp - 356]);          /* mov eax, [ebp-0x164] */
            ii(0x1012_cd18, 6); mov(memd[ss, ebp - 360], eax);          /* mov [ebp-0x168], eax */
            ii(0x1012_cd1e, 7); cmp(memd[ss, ebp - 360], 0);            /* cmp dword [ebp-0x168], 0x0 */
            ii(0x1012_cd25, 2); if(jz(0x1012_cd5b, 0x34)) goto l_0x1012_cd5b; /* jz 0x1012cd5b */
            ii(0x1012_cd27, 5); mov(eax, 0x81);                         /* mov eax, 0x81 */
            ii(0x1012_cd2c, 1); push(eax);                              /* push eax */
            ii(0x1012_cd2d, 5); mov(ecx, 0x1fd);                        /* mov ecx, 0x1fd */
            ii(0x1012_cd32, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x1012_cd37, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x1012_cd3c, 6); mov(eax, memd[ss, ebp - 356]);          /* mov eax, [ebp-0x164] */
            ii(0x1012_cd42, 5); call(Definitions.my_ctor_c17, -0x5_e938); /* call 0x100ce40f */
            ii(0x1012_cd47, 6); mov(memd[ss, ebp - 364], eax);          /* mov [ebp-0x16c], eax */
            ii(0x1012_cd4d, 6); mov(eax, memd[ss, ebp - 364]);          /* mov eax, [ebp-0x16c] */
            ii(0x1012_cd53, 6); mov(memd[ss, ebp - 180], eax);          /* mov [ebp-0xb4], eax */
            ii(0x1012_cd59, 2); jmp(0x1012_cd67, 0xc); goto l_0x1012_cd67; /* jmp 0x1012cd67 */
        l_0x1012_cd5b:
            ii(0x1012_cd5b, 6); mov(eax, memd[ss, ebp - 360]);          /* mov eax, [ebp-0x168] */
            ii(0x1012_cd61, 6); mov(memd[ss, ebp - 180], eax);          /* mov [ebp-0xb4], eax */
        l_0x1012_cd67:
            ii(0x1012_cd67, 6); mov(eax, memd[ss, ebp - 180]);          /* mov eax, [ebp-0xb4] */
            ii(0x1012_cd6d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_cd70, 6); mov(memd[ds, edx + 166], eax);          /* mov [edx+0xa6], eax */
            ii(0x1012_cd76, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_cd7b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cd7e, 6); mov(eax, memd[ds, eax + 166]);          /* mov eax, [eax+0xa6] */
            ii(0x1012_cd84, 5); call(0x100d_5194, -0x5_7bf5);           /* call 0x100d5194 */
            ii(0x1012_cd89, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_cd8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cd92, 6); mov(eax, memd[ds, eax + 166]);          /* mov eax, [eax+0xa6] */
            ii(0x1012_cd98, 5); call(0x100c_e92d, -0x5_e470);           /* call 0x100ce92d */
            ii(0x1012_cd9d, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1012_cda0, 5); call(0x100e_0ba4, -0x4_c201);           /* call 0x100e0ba4 */
            ii(0x1012_cda5, 1); push(eax);                              /* push eax */
            ii(0x1012_cda6, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1012_cda9, 5); call(0x100e_0bd0, -0x4_c1de);           /* call 0x100e0bd0 */
            ii(0x1012_cdae, 1); push(eax);                              /* push eax */
            ii(0x1012_cdaf, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1012_cdb2, 5); call(0x100e_0bfc, -0x4_c1bb);           /* call 0x100e0bfc */
            ii(0x1012_cdb7, 1); push(eax);                              /* push eax */
            ii(0x1012_cdb8, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_cdbb, 5); call(0x100e_0c28, -0x4_c198);           /* call 0x100e0c28 */
            ii(0x1012_cdc0, 6); lea(ebx, memd[ss, ebp - 432]);          /* lea ebx, [ebp-0x1b0] */
            ii(0x1012_cdc6, 5); mov(edx, StringDefinitions.Score);      /* mov edx, 0x101a8759 */
            ii(0x1012_cdcb, 3); mov(esi, memd[ss, ebp - 4]);            /* mov esi, [ebp-0x4] */
            ii(0x1012_cdce, 6); mov(esi, memd[ds, esi + 166]);          /* mov esi, [esi+0xa6] */
            ii(0x1012_cdd4, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_cdd6, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_cdd8, 5); call(0x100c_edcd, -0x5_e010);           /* call 0x100cedcd */
            ii(0x1012_cddd, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_cde0, 5); mov(edx, 0x1013_0d55);                  /* mov edx, 0x10130d55 */
            ii(0x1012_cde5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cde8, 6); mov(eax, memd[ds, eax + 166]);          /* mov eax, [eax+0xa6] */
            ii(0x1012_cdee, 5); call(0x100c_f7ec, -0x5_d607);           /* call 0x100cf7ec */
            ii(0x1012_cdf3, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_cdf8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cdfb, 6); mov(eax, memd[ds, eax + 166]);          /* mov eax, [eax+0xa6] */
            ii(0x1012_ce01, 5); call(0x100d_50d4, -0x5_7d32);           /* call 0x100d50d4 */
            ii(0x1012_ce06, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_ce0c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ce0f, 6); mov(eax, memd[ds, eax + 166]);          /* mov eax, [eax+0xa6] */
            ii(0x1012_ce15, 5); call(0x100c_f85c, -0x5_d5be);           /* call 0x100cf85c */
            ii(0x1012_ce1a, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_ce1f, 5); call(Definitions.sys_new, 0x3_8fdc);    /* call 0x10165e00 */
            ii(0x1012_ce24, 6); mov(memd[ss, ebp - 344], eax);          /* mov [ebp-0x158], eax */
            ii(0x1012_ce2a, 6); mov(eax, memd[ss, ebp - 344]);          /* mov eax, [ebp-0x158] */
            ii(0x1012_ce30, 6); mov(memd[ss, ebp - 348], eax);          /* mov [ebp-0x15c], eax */
            ii(0x1012_ce36, 7); cmp(memd[ss, ebp - 348], 0);            /* cmp dword [ebp-0x15c], 0x0 */
            ii(0x1012_ce3d, 2); if(jz(0x1012_ce73, 0x34)) goto l_0x1012_ce73; /* jz 0x1012ce73 */
            ii(0x1012_ce3f, 5); mov(eax, 0x9e);                         /* mov eax, 0x9e */
            ii(0x1012_ce44, 1); push(eax);                              /* push eax */
            ii(0x1012_ce45, 5); mov(ecx, 0x1fd);                        /* mov ecx, 0x1fd */
            ii(0x1012_ce4a, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x1012_ce4f, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x1012_ce54, 6); mov(eax, memd[ss, ebp - 344]);          /* mov eax, [ebp-0x158] */
            ii(0x1012_ce5a, 5); call(Definitions.my_ctor_c17, -0x5_ea50); /* call 0x100ce40f */
            ii(0x1012_ce5f, 6); mov(memd[ss, ebp - 352], eax);          /* mov [ebp-0x160], eax */
            ii(0x1012_ce65, 6); mov(eax, memd[ss, ebp - 352]);          /* mov eax, [ebp-0x160] */
            ii(0x1012_ce6b, 6); mov(memd[ss, ebp - 176], eax);          /* mov [ebp-0xb0], eax */
            ii(0x1012_ce71, 2); jmp(0x1012_ce7f, 0xc); goto l_0x1012_ce7f; /* jmp 0x1012ce7f */
        l_0x1012_ce73:
            ii(0x1012_ce73, 6); mov(eax, memd[ss, ebp - 348]);          /* mov eax, [ebp-0x15c] */
            ii(0x1012_ce79, 6); mov(memd[ss, ebp - 176], eax);          /* mov [ebp-0xb0], eax */
        l_0x1012_ce7f:
            ii(0x1012_ce7f, 6); mov(eax, memd[ss, ebp - 176]);          /* mov eax, [ebp-0xb0] */
            ii(0x1012_ce85, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_ce88, 6); mov(memd[ds, edx + 170], eax);          /* mov [edx+0xaa], eax */
            ii(0x1012_ce8e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_ce93, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ce96, 6); mov(eax, memd[ds, eax + 170]);          /* mov eax, [eax+0xaa] */
            ii(0x1012_ce9c, 5); call(0x100d_5194, -0x5_7d0d);           /* call 0x100d5194 */
            ii(0x1012_cea1, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_cea7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_ceaa, 6); mov(eax, memd[ds, eax + 170]);          /* mov eax, [eax+0xaa] */
            ii(0x1012_ceb0, 5); call(0x100c_e92d, -0x5_e588);           /* call 0x100ce92d */
            ii(0x1012_ceb5, 3); lea(eax, memd[ss, ebp - 116]);          /* lea eax, [ebp-0x74] */
            ii(0x1012_ceb8, 5); call(0x100e_0ba4, -0x4_c319);           /* call 0x100e0ba4 */
            ii(0x1012_cebd, 1); push(eax);                              /* push eax */
            ii(0x1012_cebe, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x1012_cec1, 5); call(0x100e_0bd0, -0x4_c2f6);           /* call 0x100e0bd0 */
            ii(0x1012_cec6, 1); push(eax);                              /* push eax */
            ii(0x1012_cec7, 3); lea(eax, memd[ss, ebp - 112]);          /* lea eax, [ebp-0x70] */
            ii(0x1012_ceca, 5); call(0x100e_0bfc, -0x4_c2d3);           /* call 0x100e0bfc */
            ii(0x1012_cecf, 1); push(eax);                              /* push eax */
            ii(0x1012_ced0, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1012_ced3, 5); call(0x100e_0c28, -0x4_c2b0);           /* call 0x100e0c28 */
            ii(0x1012_ced8, 6); lea(ebx, memd[ss, ebp - 432]);          /* lea ebx, [ebp-0x1b0] */
            ii(0x1012_cede, 5); mov(edx, StringDefinitions.Messages2);  /* mov edx, 0x101a875f */
            ii(0x1012_cee3, 3); mov(esi, memd[ss, ebp - 4]);            /* mov esi, [ebp-0x4] */
            ii(0x1012_cee6, 6); mov(esi, memd[ds, esi + 170]);          /* mov esi, [esi+0xaa] */
            ii(0x1012_ceec, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_ceee, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_cef0, 5); call(0x100c_edcd, -0x5_e128);           /* call 0x100cedcd */
            ii(0x1012_cef5, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_cef8, 5); mov(edx, 0x1013_0d9d);                  /* mov edx, 0x10130d9d */
            ii(0x1012_cefd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cf00, 6); mov(eax, memd[ds, eax + 170]);          /* mov eax, [eax+0xaa] */
            ii(0x1012_cf06, 5); call(0x100c_f7ec, -0x5_d71f);           /* call 0x100cf7ec */
            ii(0x1012_cf0b, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_cf10, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cf13, 6); mov(eax, memd[ds, eax + 170]);          /* mov eax, [eax+0xaa] */
            ii(0x1012_cf19, 5); call(0x100d_50d4, -0x5_7e4a);           /* call 0x100d50d4 */
            ii(0x1012_cf1e, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_cf24, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cf27, 6); mov(eax, memd[ds, eax + 170]);          /* mov eax, [eax+0xaa] */
            ii(0x1012_cf2d, 5); call(0x100c_f85c, -0x5_d6d6);           /* call 0x100cf85c */
            ii(0x1012_cf32, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cf35, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_cf3b, 5); call(0x100d_5104, -0x5_7e3c);           /* call 0x100d5104 */
            ii(0x1012_cf40, 6); mov(memd[ss, ebp - 476], eax);          /* mov [ebp-0x1dc], eax */
            ii(0x1012_cf46, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cf49, 6); mov(eax, memd[ds, eax + 162]);          /* mov eax, [eax+0xa2] */
            ii(0x1012_cf4f, 5); call(0x100d_5104, -0x5_7e50);           /* call 0x100d5104 */
            ii(0x1012_cf54, 6); mov(memd[ss, ebp - 472], eax);          /* mov [ebp-0x1d8], eax */
            ii(0x1012_cf5a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cf5d, 6); mov(eax, memd[ds, eax + 166]);          /* mov eax, [eax+0xa6] */
            ii(0x1012_cf63, 5); call(0x100d_5104, -0x5_7e64);           /* call 0x100d5104 */
            ii(0x1012_cf68, 6); mov(memd[ss, ebp - 468], eax);          /* mov [ebp-0x1d4], eax */
            ii(0x1012_cf6e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_cf71, 6); mov(eax, memd[ds, eax + 170]);          /* mov eax, [eax+0xaa] */
            ii(0x1012_cf77, 5); call(0x100d_5104, -0x5_7e78);           /* call 0x100d5104 */
            ii(0x1012_cf7c, 6); mov(memd[ss, ebp - 464], eax);          /* mov [ebp-0x1d0], eax */
            ii(0x1012_cf82, 6); lea(edx, memd[ss, ebp - 476]);          /* lea edx, [ebp-0x1dc] */
            ii(0x1012_cf88, 5); mov(eax, 4);                            /* mov eax, 0x4 */
            ii(0x1012_cf8d, 5); call(/* sys */ 0x1016_9a78, 0x3_cae6);  /* call 0x10169a78 */
            ii(0x1012_cf92, 3); lea(eax, memd[ss, ebp - 92]);           /* lea eax, [ebp-0x5c] */
            ii(0x1012_cf95, 5); call(0x1013_1cb4, 0x4d1a);              /* call 0x10131cb4 */
            ii(0x1012_cf9a, 1); push(eax);                              /* push eax */
            ii(0x1012_cf9b, 5); call(0x1013_1ce0, 0x4d40);              /* call 0x10131ce0 */
            ii(0x1012_cfa0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_cfa5, 1); push(eax);                              /* push eax */
            ii(0x1012_cfa6, 5); mov(eax, 0x8c);                         /* mov eax, 0x8c */
            ii(0x1012_cfab, 1); push(eax);                              /* push eax */
            ii(0x1012_cfac, 5); mov(ecx, 0xce);                         /* mov ecx, 0xce */
            ii(0x1012_cfb1, 5); mov(ebx, 0x1f1);                        /* mov ebx, 0x1f1 */
            ii(0x1012_cfb6, 5); mov(edx, StringDefinitions.Include);    /* mov edx, 0x101a8768 */
            ii(0x1012_cfbb, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_cfc1, 5); call(0x100e_a99a, -0x4_262c);           /* call 0x100ea99a */
            ii(0x1012_cfc6, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_cfcb, 5); call(Definitions.sys_new, 0x3_8e30);    /* call 0x10165e00 */
            ii(0x1012_cfd0, 6); mov(memd[ss, ebp - 328], eax);          /* mov [ebp-0x148], eax */
            ii(0x1012_cfd6, 6); mov(eax, memd[ss, ebp - 328]);          /* mov eax, [ebp-0x148] */
            ii(0x1012_cfdc, 6); mov(memd[ss, ebp - 332], eax);          /* mov [ebp-0x14c], eax */
            ii(0x1012_cfe2, 7); cmp(memd[ss, ebp - 332], 0);            /* cmp dword [ebp-0x14c], 0x0 */
            ii(0x1012_cfe9, 2); if(jz(0x1012_d01f, 0x34)) goto l_0x1012_d01f; /* jz 0x1012d01f */
            ii(0x1012_cfeb, 5); mov(eax, 0xda);                         /* mov eax, 0xda */
            ii(0x1012_cff0, 1); push(eax);                              /* push eax */
            ii(0x1012_cff1, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_cff6, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_cffb, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d000, 6); mov(eax, memd[ss, ebp - 328]);          /* mov eax, [ebp-0x148] */
            ii(0x1012_d006, 5); call(Definitions.my_ctor_c17, -0x5_ebfc); /* call 0x100ce40f */
            ii(0x1012_d00b, 6); mov(memd[ss, ebp - 336], eax);          /* mov [ebp-0x150], eax */
            ii(0x1012_d011, 6); mov(eax, memd[ss, ebp - 336]);          /* mov eax, [ebp-0x150] */
            ii(0x1012_d017, 6); mov(memd[ss, ebp - 172], eax);          /* mov [ebp-0xac], eax */
            ii(0x1012_d01d, 2); jmp(0x1012_d02b, 0xc); goto l_0x1012_d02b; /* jmp 0x1012d02b */
        l_0x1012_d01f:
            ii(0x1012_d01f, 6); mov(eax, memd[ss, ebp - 332]);          /* mov eax, [ebp-0x14c] */
            ii(0x1012_d025, 6); mov(memd[ss, ebp - 172], eax);          /* mov [ebp-0xac], eax */
        l_0x1012_d02b:
            ii(0x1012_d02b, 6); mov(eax, memd[ss, ebp - 172]);          /* mov eax, [ebp-0xac] */
            ii(0x1012_d031, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d034, 6); mov(memd[ds, edx + 174], eax);          /* mov [edx+0xae], eax */
            ii(0x1012_d03a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d03f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d042, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_d048, 5); call(0x100d_5194, -0x5_7eb9);           /* call 0x100d5194 */
            ii(0x1012_d04d, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d053, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d056, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_d05c, 5); call(0x100c_e92d, -0x5_e734);           /* call 0x100ce92d */
            ii(0x1012_d061, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d064, 5); mov(edx, 0x1013_0de5);                  /* mov edx, 0x10130de5 */
            ii(0x1012_d069, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d06c, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_d072, 5); call(0x100c_f7ec, -0x5_d88b);           /* call 0x100cf7ec */
            ii(0x1012_d077, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d07a, 5); mov(edx, 0x1013_0e3e);                  /* mov edx, 0x10130e3e */
            ii(0x1012_d07f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d082, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_d088, 5); call(0x100c_f824, -0x5_d869);           /* call 0x100cf824 */
            ii(0x1012_d08d, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d092, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d095, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_d09b, 5); call(0x100d_50d4, -0x5_7fcc);           /* call 0x100d50d4 */
            ii(0x1012_d0a0, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d0a6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d0a9, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_d0af, 5); call(0x100c_f85c, -0x5_d858);           /* call 0x100cf85c */
            ii(0x1012_d0b4, 3); lea(eax, memd[ss, ebp - 84]);           /* lea eax, [ebp-0x54] */
            ii(0x1012_d0b7, 5); call(0x1013_1cb4, 0x4bf8);              /* call 0x10131cb4 */
            ii(0x1012_d0bc, 1); push(eax);                              /* push eax */
            ii(0x1012_d0bd, 5); call(0x1013_1ce0, 0x4c1e);              /* call 0x10131ce0 */
            ii(0x1012_d0c2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d0c7, 1); push(eax);                              /* push eax */
            ii(0x1012_d0c8, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d0cd, 1); push(eax);                              /* push eax */
            ii(0x1012_d0ce, 5); mov(ecx, 0xdc);                         /* mov ecx, 0xdc */
            ii(0x1012_d0d3, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d0d8, 5); mov(edx, StringDefinitions.AirUnits);   /* mov edx, 0x101a8771 */
            ii(0x1012_d0dd, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d0e3, 5); call(0x100e_a99a, -0x4_274e);           /* call 0x100ea99a */
            ii(0x1012_d0e8, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d0ed, 5); call(Definitions.sys_new, 0x3_8d0e);    /* call 0x10165e00 */
            ii(0x1012_d0f2, 6); mov(memd[ss, ebp - 316], eax);          /* mov [ebp-0x13c], eax */
            ii(0x1012_d0f8, 6); mov(eax, memd[ss, ebp - 316]);          /* mov eax, [ebp-0x13c] */
            ii(0x1012_d0fe, 6); mov(memd[ss, ebp - 320], eax);          /* mov [ebp-0x140], eax */
            ii(0x1012_d104, 7); cmp(memd[ss, ebp - 320], 0);            /* cmp dword [ebp-0x140], 0x0 */
            ii(0x1012_d10b, 2); if(jz(0x1012_d141, 0x34)) goto l_0x1012_d141; /* jz 0x1012d141 */
            ii(0x1012_d10d, 5); mov(eax, 0xec);                         /* mov eax, 0xec */
            ii(0x1012_d112, 1); push(eax);                              /* push eax */
            ii(0x1012_d113, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_d118, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_d11d, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d122, 6); mov(eax, memd[ss, ebp - 316]);          /* mov eax, [ebp-0x13c] */
            ii(0x1012_d128, 5); call(Definitions.my_ctor_c17, -0x5_ed1e); /* call 0x100ce40f */
            ii(0x1012_d12d, 6); mov(memd[ss, ebp - 324], eax);          /* mov [ebp-0x144], eax */
            ii(0x1012_d133, 6); mov(eax, memd[ss, ebp - 324]);          /* mov eax, [ebp-0x144] */
            ii(0x1012_d139, 6); mov(memd[ss, ebp - 168], eax);          /* mov [ebp-0xa8], eax */
            ii(0x1012_d13f, 2); jmp(0x1012_d14d, 0xc); goto l_0x1012_d14d; /* jmp 0x1012d14d */
        l_0x1012_d141:
            ii(0x1012_d141, 6); mov(eax, memd[ss, ebp - 320]);          /* mov eax, [ebp-0x140] */
            ii(0x1012_d147, 6); mov(memd[ss, ebp - 168], eax);          /* mov [ebp-0xa8], eax */
        l_0x1012_d14d:
            ii(0x1012_d14d, 6); mov(eax, memd[ss, ebp - 168]);          /* mov eax, [ebp-0xa8] */
            ii(0x1012_d153, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d156, 6); mov(memd[ds, edx + 178], eax);          /* mov [edx+0xb2], eax */
            ii(0x1012_d15c, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d161, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d164, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_d16a, 5); call(0x100d_5194, -0x5_7fdb);           /* call 0x100d5194 */
            ii(0x1012_d16f, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d175, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d178, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_d17e, 5); call(0x100c_e92d, -0x5_e856);           /* call 0x100ce92d */
            ii(0x1012_d183, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d186, 5); mov(edx, 0x1013_0e97);                  /* mov edx, 0x10130e97 */
            ii(0x1012_d18b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d18e, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_d194, 5); call(0x100c_f7ec, -0x5_d9ad);           /* call 0x100cf7ec */
            ii(0x1012_d199, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d19c, 5); mov(edx, 0x1013_0ef0);                  /* mov edx, 0x10130ef0 */
            ii(0x1012_d1a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d1a4, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_d1aa, 5); call(0x100c_f824, -0x5_d98b);           /* call 0x100cf824 */
            ii(0x1012_d1af, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d1b4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d1b7, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_d1bd, 5); call(0x100d_50d4, -0x5_80ee);           /* call 0x100d50d4 */
            ii(0x1012_d1c2, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d1c8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d1cb, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_d1d1, 5); call(0x100c_f85c, -0x5_d97a);           /* call 0x100cf85c */
            ii(0x1012_d1d6, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1012_d1d9, 5); call(0x1013_1cb4, 0x4ad6);              /* call 0x10131cb4 */
            ii(0x1012_d1de, 1); push(eax);                              /* push eax */
            ii(0x1012_d1df, 5); call(0x1013_1ce0, 0x4afc);              /* call 0x10131ce0 */
            ii(0x1012_d1e4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d1e9, 1); push(eax);                              /* push eax */
            ii(0x1012_d1ea, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d1ef, 1); push(eax);                              /* push eax */
            ii(0x1012_d1f0, 5); mov(ecx, 0xee);                         /* mov ecx, 0xee */
            ii(0x1012_d1f5, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d1fa, 5); mov(edx, StringDefinitions.LandUnits);  /* mov edx, 0x101a877b */
            ii(0x1012_d1ff, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d205, 5); call(0x100e_a99a, -0x4_2870);           /* call 0x100ea99a */
            ii(0x1012_d20a, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d20f, 5); call(Definitions.sys_new, 0x3_8bec);    /* call 0x10165e00 */
            ii(0x1012_d214, 6); mov(memd[ss, ebp - 304], eax);          /* mov [ebp-0x130], eax */
            ii(0x1012_d21a, 6); mov(eax, memd[ss, ebp - 304]);          /* mov eax, [ebp-0x130] */
            ii(0x1012_d220, 6); mov(memd[ss, ebp - 308], eax);          /* mov [ebp-0x134], eax */
            ii(0x1012_d226, 7); cmp(memd[ss, ebp - 308], 0);            /* cmp dword [ebp-0x134], 0x0 */
            ii(0x1012_d22d, 2); if(jz(0x1012_d263, 0x34)) goto l_0x1012_d263; /* jz 0x1012d263 */
            ii(0x1012_d22f, 5); mov(eax, 0xfe);                         /* mov eax, 0xfe */
            ii(0x1012_d234, 1); push(eax);                              /* push eax */
            ii(0x1012_d235, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_d23a, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_d23f, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d244, 6); mov(eax, memd[ss, ebp - 304]);          /* mov eax, [ebp-0x130] */
            ii(0x1012_d24a, 5); call(Definitions.my_ctor_c17, -0x5_ee40); /* call 0x100ce40f */
            ii(0x1012_d24f, 6); mov(memd[ss, ebp - 312], eax);          /* mov [ebp-0x138], eax */
            ii(0x1012_d255, 6); mov(eax, memd[ss, ebp - 312]);          /* mov eax, [ebp-0x138] */
            ii(0x1012_d25b, 6); mov(memd[ss, ebp - 164], eax);          /* mov [ebp-0xa4], eax */
            ii(0x1012_d261, 2); jmp(0x1012_d26f, 0xc); goto l_0x1012_d26f; /* jmp 0x1012d26f */
        l_0x1012_d263:
            ii(0x1012_d263, 6); mov(eax, memd[ss, ebp - 308]);          /* mov eax, [ebp-0x134] */
            ii(0x1012_d269, 6); mov(memd[ss, ebp - 164], eax);          /* mov [ebp-0xa4], eax */
        l_0x1012_d26f:
            ii(0x1012_d26f, 6); mov(eax, memd[ss, ebp - 164]);          /* mov eax, [ebp-0xa4] */
            ii(0x1012_d275, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d278, 6); mov(memd[ds, edx + 182], eax);          /* mov [edx+0xb6], eax */
            ii(0x1012_d27e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d283, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d286, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_d28c, 5); call(0x100d_5194, -0x5_80fd);           /* call 0x100d5194 */
            ii(0x1012_d291, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d297, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d29a, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_d2a0, 5); call(0x100c_e92d, -0x5_e978);           /* call 0x100ce92d */
            ii(0x1012_d2a5, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d2a8, 5); mov(edx, 0x1013_0f49);                  /* mov edx, 0x10130f49 */
            ii(0x1012_d2ad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d2b0, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_d2b6, 5); call(0x100c_f7ec, -0x5_dacf);           /* call 0x100cf7ec */
            ii(0x1012_d2bb, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d2be, 5); mov(edx, 0x1013_0fa2);                  /* mov edx, 0x10130fa2 */
            ii(0x1012_d2c3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d2c6, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_d2cc, 5); call(0x100c_f824, -0x5_daad);           /* call 0x100cf824 */
            ii(0x1012_d2d1, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d2d6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d2d9, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_d2df, 5); call(0x100d_50d4, -0x5_8210);           /* call 0x100d50d4 */
            ii(0x1012_d2e4, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d2ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d2ed, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_d2f3, 5); call(0x100c_f85c, -0x5_da9c);           /* call 0x100cf85c */
            ii(0x1012_d2f8, 3); lea(eax, memd[ss, ebp - 108]);          /* lea eax, [ebp-0x6c] */
            ii(0x1012_d2fb, 5); call(0x1013_1cb4, 0x49b4);              /* call 0x10131cb4 */
            ii(0x1012_d300, 1); push(eax);                              /* push eax */
            ii(0x1012_d301, 5); call(0x1013_1ce0, 0x49da);              /* call 0x10131ce0 */
            ii(0x1012_d306, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d30b, 1); push(eax);                              /* push eax */
            ii(0x1012_d30c, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d311, 1); push(eax);                              /* push eax */
            ii(0x1012_d312, 5); mov(ecx, 0x100);                        /* mov ecx, 0x100 */
            ii(0x1012_d317, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d31c, 5); mov(edx, StringDefinitions.SeaUnits);   /* mov edx, 0x101a8786 */
            ii(0x1012_d321, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d327, 5); call(0x100e_a99a, -0x4_2992);           /* call 0x100ea99a */
            ii(0x1012_d32c, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d331, 5); call(Definitions.sys_new, 0x3_8aca);    /* call 0x10165e00 */
            ii(0x1012_d336, 6); mov(memd[ss, ebp - 292], eax);          /* mov [ebp-0x124], eax */
            ii(0x1012_d33c, 6); mov(eax, memd[ss, ebp - 292]);          /* mov eax, [ebp-0x124] */
            ii(0x1012_d342, 6); mov(memd[ss, ebp - 296], eax);          /* mov [ebp-0x128], eax */
            ii(0x1012_d348, 7); cmp(memd[ss, ebp - 296], 0);            /* cmp dword [ebp-0x128], 0x0 */
            ii(0x1012_d34f, 2); if(jz(0x1012_d385, 0x34)) goto l_0x1012_d385; /* jz 0x1012d385 */
            ii(0x1012_d351, 5); mov(eax, 0x110);                        /* mov eax, 0x110 */
            ii(0x1012_d356, 1); push(eax);                              /* push eax */
            ii(0x1012_d357, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_d35c, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_d361, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d366, 6); mov(eax, memd[ss, ebp - 292]);          /* mov eax, [ebp-0x124] */
            ii(0x1012_d36c, 5); call(Definitions.my_ctor_c17, -0x5_ef62); /* call 0x100ce40f */
            ii(0x1012_d371, 6); mov(memd[ss, ebp - 300], eax);          /* mov [ebp-0x12c], eax */
            ii(0x1012_d377, 6); mov(eax, memd[ss, ebp - 300]);          /* mov eax, [ebp-0x12c] */
            ii(0x1012_d37d, 6); mov(memd[ss, ebp - 160], eax);          /* mov [ebp-0xa0], eax */
            ii(0x1012_d383, 2); jmp(0x1012_d391, 0xc); goto l_0x1012_d391; /* jmp 0x1012d391 */
        l_0x1012_d385:
            ii(0x1012_d385, 6); mov(eax, memd[ss, ebp - 296]);          /* mov eax, [ebp-0x128] */
            ii(0x1012_d38b, 6); mov(memd[ss, ebp - 160], eax);          /* mov [ebp-0xa0], eax */
        l_0x1012_d391:
            ii(0x1012_d391, 6); mov(eax, memd[ss, ebp - 160]);          /* mov eax, [ebp-0xa0] */
            ii(0x1012_d397, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d39a, 6); mov(memd[ds, edx + 186], eax);          /* mov [edx+0xba], eax */
            ii(0x1012_d3a0, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d3a5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d3a8, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_d3ae, 5); call(0x100d_5194, -0x5_821f);           /* call 0x100d5194 */
            ii(0x1012_d3b3, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d3b9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d3bc, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_d3c2, 5); call(0x100c_e92d, -0x5_ea9a);           /* call 0x100ce92d */
            ii(0x1012_d3c7, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d3ca, 5); mov(edx, 0x1013_0ffb);                  /* mov edx, 0x10130ffb */
            ii(0x1012_d3cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d3d2, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_d3d8, 5); call(0x100c_f7ec, -0x5_dbf1);           /* call 0x100cf7ec */
            ii(0x1012_d3dd, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d3e0, 5); mov(edx, 0x1013_1054);                  /* mov edx, 0x10131054 */
            ii(0x1012_d3e5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d3e8, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_d3ee, 5); call(0x100c_f824, -0x5_dbcf);           /* call 0x100cf824 */
            ii(0x1012_d3f3, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d3f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d3fb, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_d401, 5); call(0x100d_50d4, -0x5_8332);           /* call 0x100d50d4 */
            ii(0x1012_d406, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d40c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d40f, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_d415, 5); call(0x100c_f85c, -0x5_dbbe);           /* call 0x100cf85c */
            ii(0x1012_d41a, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1012_d41d, 5); call(0x1013_1cb4, 0x4892);              /* call 0x10131cb4 */
            ii(0x1012_d422, 1); push(eax);                              /* push eax */
            ii(0x1012_d423, 5); call(0x1013_1ce0, 0x48b8);              /* call 0x10131ce0 */
            ii(0x1012_d428, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d42d, 1); push(eax);                              /* push eax */
            ii(0x1012_d42e, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d433, 1); push(eax);                              /* push eax */
            ii(0x1012_d434, 5); mov(ecx, 0x112);                        /* mov ecx, 0x112 */
            ii(0x1012_d439, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d43e, 5); mov(edx, StringDefinitions.StationaryUnits); /* mov edx, 0x101a8790 */
            ii(0x1012_d443, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d449, 5); call(0x100e_a99a, -0x4_2ab4);           /* call 0x100ea99a */
            ii(0x1012_d44e, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x1012_d451, 5); call(0x1013_1cb4, 0x485e);              /* call 0x10131cb4 */
            ii(0x1012_d456, 1); push(eax);                              /* push eax */
            ii(0x1012_d457, 5); call(0x1013_1ce0, 0x4884);              /* call 0x10131ce0 */
            ii(0x1012_d45c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d461, 1); push(eax);                              /* push eax */
            ii(0x1012_d462, 5); mov(eax, 0x8c);                         /* mov eax, 0x8c */
            ii(0x1012_d467, 1); push(eax);                              /* push eax */
            ii(0x1012_d468, 5); mov(ecx, 0x12a);                        /* mov ecx, 0x12a */
            ii(0x1012_d46d, 5); mov(ebx, 0x1f1);                        /* mov ebx, 0x1f1 */
            ii(0x1012_d472, 5); mov(edx, StringDefinitions.LimitTo);    /* mov edx, 0x101a87a1 */
            ii(0x1012_d477, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d47d, 5); call(0x100e_a99a, -0x4_2ae8);           /* call 0x100ea99a */
            ii(0x1012_d482, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d487, 5); call(Definitions.sys_new, 0x3_8974);    /* call 0x10165e00 */
            ii(0x1012_d48c, 6); mov(memd[ss, ebp - 280], eax);          /* mov [ebp-0x118], eax */
            ii(0x1012_d492, 6); mov(eax, memd[ss, ebp - 280]);          /* mov eax, [ebp-0x118] */
            ii(0x1012_d498, 6); mov(memd[ss, ebp - 284], eax);          /* mov [ebp-0x11c], eax */
            ii(0x1012_d49e, 7); cmp(memd[ss, ebp - 284], 0);            /* cmp dword [ebp-0x11c], 0x0 */
            ii(0x1012_d4a5, 2); if(jz(0x1012_d4db, 0x34)) goto l_0x1012_d4db; /* jz 0x1012d4db */
            ii(0x1012_d4a7, 5); mov(eax, 0x138);                        /* mov eax, 0x138 */
            ii(0x1012_d4ac, 1); push(eax);                              /* push eax */
            ii(0x1012_d4ad, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_d4b2, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_d4b7, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d4bc, 6); mov(eax, memd[ss, ebp - 280]);          /* mov eax, [ebp-0x118] */
            ii(0x1012_d4c2, 5); call(Definitions.my_ctor_c17, -0x5_f0b8); /* call 0x100ce40f */
            ii(0x1012_d4c7, 6); mov(memd[ss, ebp - 288], eax);          /* mov [ebp-0x120], eax */
            ii(0x1012_d4cd, 6); mov(eax, memd[ss, ebp - 288]);          /* mov eax, [ebp-0x120] */
            ii(0x1012_d4d3, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
            ii(0x1012_d4d9, 2); jmp(0x1012_d4e7, 0xc); goto l_0x1012_d4e7; /* jmp 0x1012d4e7 */
        l_0x1012_d4db:
            ii(0x1012_d4db, 6); mov(eax, memd[ss, ebp - 284]);          /* mov eax, [ebp-0x11c] */
            ii(0x1012_d4e1, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
        l_0x1012_d4e7:
            ii(0x1012_d4e7, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x1012_d4ed, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d4f0, 6); mov(memd[ds, edx + 190], eax);          /* mov [edx+0xbe], eax */
            ii(0x1012_d4f6, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d4fb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d4fe, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_d504, 5); call(0x100d_5194, -0x5_8375);           /* call 0x100d5194 */
            ii(0x1012_d509, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d50f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d512, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_d518, 5); call(0x100c_e92d, -0x5_ebf0);           /* call 0x100ce92d */
            ii(0x1012_d51d, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d520, 5); mov(edx, 0x1013_10ad);                  /* mov edx, 0x101310ad */
            ii(0x1012_d525, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d528, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_d52e, 5); call(0x100c_f7ec, -0x5_dd47);           /* call 0x100cf7ec */
            ii(0x1012_d533, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d536, 5); mov(edx, 0x1013_1134);                  /* mov edx, 0x10131134 */
            ii(0x1012_d53b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d53e, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_d544, 5); call(0x100c_f824, -0x5_dd25);           /* call 0x100cf824 */
            ii(0x1012_d549, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d54e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d551, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_d557, 5); call(0x100d_50d4, -0x5_8488);           /* call 0x100d50d4 */
            ii(0x1012_d55c, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d562, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d565, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_d56b, 5); call(0x100c_f85c, -0x5_dd14);           /* call 0x100cf85c */
            ii(0x1012_d570, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x1012_d573, 5); call(0x1013_1cb4, 0x473c);              /* call 0x10131cb4 */
            ii(0x1012_d578, 1); push(eax);                              /* push eax */
            ii(0x1012_d579, 5); call(0x1013_1ce0, 0x4762);              /* call 0x10131ce0 */
            ii(0x1012_d57e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d583, 1); push(eax);                              /* push eax */
            ii(0x1012_d584, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d589, 1); push(eax);                              /* push eax */
            ii(0x1012_d58a, 5); mov(ecx, 0x13a);                        /* mov ecx, 0x13a */
            ii(0x1012_d58f, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d594, 5); mov(edx, StringDefinitions.ProductionUnits); /* mov edx, 0x101a87ab */
            ii(0x1012_d599, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d59f, 5); call(0x100e_a99a, -0x4_2c0a);           /* call 0x100ea99a */
            ii(0x1012_d5a4, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d5a9, 5); call(Definitions.sys_new, 0x3_8852);    /* call 0x10165e00 */
            ii(0x1012_d5ae, 6); mov(memd[ss, ebp - 268], eax);          /* mov [ebp-0x10c], eax */
            ii(0x1012_d5b4, 6); mov(eax, memd[ss, ebp - 268]);          /* mov eax, [ebp-0x10c] */
            ii(0x1012_d5ba, 6); mov(memd[ss, ebp - 272], eax);          /* mov [ebp-0x110], eax */
            ii(0x1012_d5c0, 7); cmp(memd[ss, ebp - 272], 0);            /* cmp dword [ebp-0x110], 0x0 */
            ii(0x1012_d5c7, 2); if(jz(0x1012_d5fd, 0x34)) goto l_0x1012_d5fd; /* jz 0x1012d5fd */
            ii(0x1012_d5c9, 5); mov(eax, 0x14a);                        /* mov eax, 0x14a */
            ii(0x1012_d5ce, 1); push(eax);                              /* push eax */
            ii(0x1012_d5cf, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_d5d4, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_d5d9, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d5de, 6); mov(eax, memd[ss, ebp - 268]);          /* mov eax, [ebp-0x10c] */
            ii(0x1012_d5e4, 5); call(Definitions.my_ctor_c17, -0x5_f1da); /* call 0x100ce40f */
            ii(0x1012_d5e9, 6); mov(memd[ss, ebp - 276], eax);          /* mov [ebp-0x114], eax */
            ii(0x1012_d5ef, 6); mov(eax, memd[ss, ebp - 276]);          /* mov eax, [ebp-0x114] */
            ii(0x1012_d5f5, 6); mov(memd[ss, ebp - 152], eax);          /* mov [ebp-0x98], eax */
            ii(0x1012_d5fb, 2); jmp(0x1012_d609, 0xc); goto l_0x1012_d609; /* jmp 0x1012d609 */
        l_0x1012_d5fd:
            ii(0x1012_d5fd, 6); mov(eax, memd[ss, ebp - 272]);          /* mov eax, [ebp-0x110] */
            ii(0x1012_d603, 6); mov(memd[ss, ebp - 152], eax);          /* mov [ebp-0x98], eax */
        l_0x1012_d609:
            ii(0x1012_d609, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x1012_d60f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d612, 6); mov(memd[ds, edx + 194], eax);          /* mov [edx+0xc2], eax */
            ii(0x1012_d618, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d61d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d620, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_d626, 5); call(0x100d_5194, -0x5_8497);           /* call 0x100d5194 */
            ii(0x1012_d62b, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d631, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d634, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_d63a, 5); call(0x100c_e92d, -0x5_ed12);           /* call 0x100ce92d */
            ii(0x1012_d63f, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d642, 5); mov(edx, 0x1013_118d);                  /* mov edx, 0x1013118d */
            ii(0x1012_d647, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d64a, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_d650, 5); call(0x100c_f7ec, -0x5_de69);           /* call 0x100cf7ec */
            ii(0x1012_d655, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d658, 5); mov(edx, 0x1013_11fd);                  /* mov edx, 0x101311fd */
            ii(0x1012_d65d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d660, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_d666, 5); call(0x100c_f824, -0x5_de47);           /* call 0x100cf824 */
            ii(0x1012_d66b, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d670, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d673, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_d679, 5); call(0x100d_50d4, -0x5_85aa);           /* call 0x100d50d4 */
            ii(0x1012_d67e, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d684, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d687, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_d68d, 5); call(0x100c_f85c, -0x5_de36);           /* call 0x100cf85c */
            ii(0x1012_d692, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1012_d695, 5); call(0x1013_1cb4, 0x461a);              /* call 0x10131cb4 */
            ii(0x1012_d69a, 1); push(eax);                              /* push eax */
            ii(0x1012_d69b, 5); call(0x1013_1ce0, 0x4640);              /* call 0x10131ce0 */
            ii(0x1012_d6a0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d6a5, 1); push(eax);                              /* push eax */
            ii(0x1012_d6a6, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d6ab, 1); push(eax);                              /* push eax */
            ii(0x1012_d6ac, 5); mov(ecx, 0x14c);                        /* mov ecx, 0x14c */
            ii(0x1012_d6b1, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d6b6, 5); mov(edx, StringDefinitions.CombatUnits); /* mov edx, 0x101a87bc */
            ii(0x1012_d6bb, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d6c1, 5); call(0x100e_a99a, -0x4_2d2c);           /* call 0x100ea99a */
            ii(0x1012_d6c6, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d6cb, 5); call(Definitions.sys_new, 0x3_8730);    /* call 0x10165e00 */
            ii(0x1012_d6d0, 6); mov(memd[ss, ebp - 256], eax);          /* mov [ebp-0x100], eax */
            ii(0x1012_d6d6, 6); mov(eax, memd[ss, ebp - 256]);          /* mov eax, [ebp-0x100] */
            ii(0x1012_d6dc, 6); mov(memd[ss, ebp - 260], eax);          /* mov [ebp-0x104], eax */
            ii(0x1012_d6e2, 7); cmp(memd[ss, ebp - 260], 0);            /* cmp dword [ebp-0x104], 0x0 */
            ii(0x1012_d6e9, 2); if(jz(0x1012_d71f, 0x34)) goto l_0x1012_d71f; /* jz 0x1012d71f */
            ii(0x1012_d6eb, 5); mov(eax, 0x15c);                        /* mov eax, 0x15c */
            ii(0x1012_d6f0, 1); push(eax);                              /* push eax */
            ii(0x1012_d6f1, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_d6f6, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_d6fb, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d700, 6); mov(eax, memd[ss, ebp - 256]);          /* mov eax, [ebp-0x100] */
            ii(0x1012_d706, 5); call(Definitions.my_ctor_c17, -0x5_f2fc); /* call 0x100ce40f */
            ii(0x1012_d70b, 6); mov(memd[ss, ebp - 264], eax);          /* mov [ebp-0x108], eax */
            ii(0x1012_d711, 6); mov(eax, memd[ss, ebp - 264]);          /* mov eax, [ebp-0x108] */
            ii(0x1012_d717, 6); mov(memd[ss, ebp - 148], eax);          /* mov [ebp-0x94], eax */
            ii(0x1012_d71d, 2); jmp(0x1012_d72b, 0xc); goto l_0x1012_d72b; /* jmp 0x1012d72b */
        l_0x1012_d71f:
            ii(0x1012_d71f, 6); mov(eax, memd[ss, ebp - 260]);          /* mov eax, [ebp-0x104] */
            ii(0x1012_d725, 6); mov(memd[ss, ebp - 148], eax);          /* mov [ebp-0x94], eax */
        l_0x1012_d72b:
            ii(0x1012_d72b, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x1012_d731, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d734, 6); mov(memd[ds, edx + 198], eax);          /* mov [edx+0xc6], eax */
            ii(0x1012_d73a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d73f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d742, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_d748, 5); call(0x100d_5194, -0x5_85b9);           /* call 0x100d5194 */
            ii(0x1012_d74d, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d753, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d756, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_d75c, 5); call(0x100c_e92d, -0x5_ee34);           /* call 0x100ce92d */
            ii(0x1012_d761, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d764, 5); mov(edx, 0x1013_1256);                  /* mov edx, 0x10131256 */
            ii(0x1012_d769, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d76c, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_d772, 5); call(0x100c_f7ec, -0x5_df8b);           /* call 0x100cf7ec */
            ii(0x1012_d777, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d77a, 5); mov(edx, 0x1013_12a6);                  /* mov edx, 0x101312a6 */
            ii(0x1012_d77f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d782, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_d788, 5); call(0x100c_f824, -0x5_df69);           /* call 0x100cf824 */
            ii(0x1012_d78d, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d792, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d795, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_d79b, 5); call(0x100d_50d4, -0x5_86cc);           /* call 0x100d50d4 */
            ii(0x1012_d7a0, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d7a6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d7a9, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_d7af, 5); call(0x100c_f85c, -0x5_df58);           /* call 0x100cf85c */
            ii(0x1012_d7b4, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1012_d7b7, 5); call(0x1013_1cb4, 0x44f8);              /* call 0x10131cb4 */
            ii(0x1012_d7bc, 1); push(eax);                              /* push eax */
            ii(0x1012_d7bd, 5); call(0x1013_1ce0, 0x451e);              /* call 0x10131ce0 */
            ii(0x1012_d7c2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d7c7, 1); push(eax);                              /* push eax */
            ii(0x1012_d7c8, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d7cd, 1); push(eax);                              /* push eax */
            ii(0x1012_d7ce, 5); mov(ecx, 0x15e);                        /* mov ecx, 0x15e */
            ii(0x1012_d7d3, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d7d8, 5); mov(edx, StringDefinitions.DamagedUnits); /* mov edx, 0x101a87c9 */
            ii(0x1012_d7dd, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d7e3, 5); call(0x100e_a99a, -0x4_2e4e);           /* call 0x100ea99a */
            ii(0x1012_d7e8, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d7ed, 5); call(Definitions.sys_new, 0x3_860e);    /* call 0x10165e00 */
            ii(0x1012_d7f2, 6); mov(memd[ss, ebp - 244], eax);          /* mov [ebp-0xf4], eax */
            ii(0x1012_d7f8, 6); mov(eax, memd[ss, ebp - 244]);          /* mov eax, [ebp-0xf4] */
            ii(0x1012_d7fe, 6); mov(memd[ss, ebp - 248], eax);          /* mov [ebp-0xf8], eax */
            ii(0x1012_d804, 7); cmp(memd[ss, ebp - 248], 0);            /* cmp dword [ebp-0xf8], 0x0 */
            ii(0x1012_d80b, 2); if(jz(0x1012_d841, 0x34)) goto l_0x1012_d841; /* jz 0x1012d841 */
            ii(0x1012_d80d, 5); mov(eax, 0x16e);                        /* mov eax, 0x16e */
            ii(0x1012_d812, 1); push(eax);                              /* push eax */
            ii(0x1012_d813, 5); mov(ecx, 0x1f0);                        /* mov ecx, 0x1f0 */
            ii(0x1012_d818, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_d81d, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_d822, 6); mov(eax, memd[ss, ebp - 244]);          /* mov eax, [ebp-0xf4] */
            ii(0x1012_d828, 5); call(Definitions.my_ctor_c17, -0x5_f41e); /* call 0x100ce40f */
            ii(0x1012_d82d, 6); mov(memd[ss, ebp - 252], eax);          /* mov [ebp-0xfc], eax */
            ii(0x1012_d833, 6); mov(eax, memd[ss, ebp - 252]);          /* mov eax, [ebp-0xfc] */
            ii(0x1012_d839, 6); mov(memd[ss, ebp - 144], eax);          /* mov [ebp-0x90], eax */
            ii(0x1012_d83f, 2); jmp(0x1012_d84d, 0xc); goto l_0x1012_d84d; /* jmp 0x1012d84d */
        l_0x1012_d841:
            ii(0x1012_d841, 6); mov(eax, memd[ss, ebp - 248]);          /* mov eax, [ebp-0xf8] */
            ii(0x1012_d847, 6); mov(memd[ss, ebp - 144], eax);          /* mov [ebp-0x90], eax */
        l_0x1012_d84d:
            ii(0x1012_d84d, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x1012_d853, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d856, 6); mov(memd[ds, edx + 202], eax);          /* mov [edx+0xca], eax */
            ii(0x1012_d85c, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_d861, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d864, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_d86a, 5); call(0x100d_5194, -0x5_86db);           /* call 0x100d5194 */
            ii(0x1012_d86f, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d875, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d878, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_d87e, 5); call(0x100c_e92d, -0x5_ef56);           /* call 0x100ce92d */
            ii(0x1012_d883, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d886, 5); mov(edx, 0x1013_12f6);                  /* mov edx, 0x101312f6 */
            ii(0x1012_d88b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d88e, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_d894, 5); call(0x100c_f7ec, -0x5_e0ad);           /* call 0x100cf7ec */
            ii(0x1012_d899, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d89c, 5); mov(edx, 0x1013_1366);                  /* mov edx, 0x10131366 */
            ii(0x1012_d8a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d8a4, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_d8aa, 5); call(0x100c_f824, -0x5_e08b);           /* call 0x100cf824 */
            ii(0x1012_d8af, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d8b4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d8b7, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_d8bd, 5); call(0x100d_50d4, -0x5_87ee);           /* call 0x100d50d4 */
            ii(0x1012_d8c2, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d8c8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d8cb, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_d8d1, 5); call(0x100c_f85c, -0x5_e07a);           /* call 0x100cf85c */
            ii(0x1012_d8d6, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1012_d8d9, 5); call(0x1013_1cb4, 0x43d6);              /* call 0x10131cb4 */
            ii(0x1012_d8de, 1); push(eax);                              /* push eax */
            ii(0x1012_d8df, 5); call(0x1013_1ce0, 0x43fc);              /* call 0x10131ce0 */
            ii(0x1012_d8e4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_d8e9, 1); push(eax);                              /* push eax */
            ii(0x1012_d8ea, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1012_d8ef, 1); push(eax);                              /* push eax */
            ii(0x1012_d8f0, 5); mov(ecx, 0x170);                        /* mov ecx, 0x170 */
            ii(0x1012_d8f5, 5); mov(ebx, 0x205);                        /* mov ebx, 0x205 */
            ii(0x1012_d8fa, 5); mov(edx, StringDefinitions.StealthyUnits); /* mov edx, 0x101a87d7 */
            ii(0x1012_d8ff, 6); lea(eax, memd[ss, ebp - 460]);          /* lea eax, [ebp-0x1cc] */
            ii(0x1012_d905, 5); call(0x100e_a99a, -0x4_2f70);           /* call 0x100ea99a */
            ii(0x1012_d90a, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d90f, 5); call(Definitions.sys_new, 0x3_84ec);    /* call 0x10165e00 */
            ii(0x1012_d914, 6); mov(memd[ss, ebp - 232], eax);          /* mov [ebp-0xe8], eax */
            ii(0x1012_d91a, 6); mov(eax, memd[ss, ebp - 232]);          /* mov eax, [ebp-0xe8] */
            ii(0x1012_d920, 6); mov(memd[ss, ebp - 236], eax);          /* mov [ebp-0xec], eax */
            ii(0x1012_d926, 7); cmp(memd[ss, ebp - 236], 0);            /* cmp dword [ebp-0xec], 0x0 */
            ii(0x1012_d92d, 2); if(jz(0x1012_d963, 0x34)) goto l_0x1012_d963; /* jz 0x1012d963 */
            ii(0x1012_d92f, 5); mov(eax, 0x1aa);                        /* mov eax, 0x1aa */
            ii(0x1012_d934, 1); push(eax);                              /* push eax */
            ii(0x1012_d935, 5); mov(ecx, 0x1e7);                        /* mov ecx, 0x1e7 */
            ii(0x1012_d93a, 5); mov(ebx, 0x193);                        /* mov ebx, 0x193 */
            ii(0x1012_d93f, 5); mov(edx, 0x192);                        /* mov edx, 0x192 */
            ii(0x1012_d944, 6); mov(eax, memd[ss, ebp - 232]);          /* mov eax, [ebp-0xe8] */
            ii(0x1012_d94a, 5); call(Definitions.my_ctor_c17, -0x5_f540); /* call 0x100ce40f */
            ii(0x1012_d94f, 6); mov(memd[ss, ebp - 240], eax);          /* mov [ebp-0xf0], eax */
            ii(0x1012_d955, 6); mov(eax, memd[ss, ebp - 240]);          /* mov eax, [ebp-0xf0] */
            ii(0x1012_d95b, 6); mov(memd[ss, ebp - 136], eax);          /* mov [ebp-0x88], eax */
            ii(0x1012_d961, 2); jmp(0x1012_d96f, 0xc); goto l_0x1012_d96f; /* jmp 0x1012d96f */
        l_0x1012_d963:
            ii(0x1012_d963, 6); mov(eax, memd[ss, ebp - 236]);          /* mov eax, [ebp-0xec] */
            ii(0x1012_d969, 6); mov(memd[ss, ebp - 136], eax);          /* mov [ebp-0x88], eax */
        l_0x1012_d96f:
            ii(0x1012_d96f, 6); mov(eax, memd[ss, ebp - 136]);          /* mov eax, [ebp-0x88] */
            ii(0x1012_d975, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_d978, 6); mov(memd[ds, edx + 206], eax);          /* mov [edx+0xce], eax */
            ii(0x1012_d97e, 5); mov(edx, 0x194);                        /* mov edx, 0x194 */
            ii(0x1012_d983, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d986, 6); mov(eax, memd[ds, eax + 206]);          /* mov eax, [eax+0xce] */
            ii(0x1012_d98c, 5); call(0x100c_f2ba, -0x5_e6d7);           /* call 0x100cf2ba */
            ii(0x1012_d991, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d997, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d99a, 6); mov(eax, memd[ds, eax + 206]);          /* mov eax, [eax+0xce] */
            ii(0x1012_d9a0, 5); call(0x100c_e92d, -0x5_f078);           /* call 0x100ce92d */
            ii(0x1012_d9a5, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_d9a8, 5); mov(edx, 0x1013_13bf);                  /* mov edx, 0x101313bf */
            ii(0x1012_d9ad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d9b0, 6); mov(eax, memd[ds, eax + 206]);          /* mov eax, [eax+0xce] */
            ii(0x1012_d9b6, 5); call(0x100c_f824, -0x5_e197);           /* call 0x100cf824 */
            ii(0x1012_d9bb, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_d9c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d9c3, 6); mov(eax, memd[ds, eax + 206]);          /* mov eax, [eax+0xce] */
            ii(0x1012_d9c9, 5); call(0x100d_50d4, -0x5_88fa);           /* call 0x100d50d4 */
            ii(0x1012_d9ce, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_d9d4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_d9d7, 6); mov(eax, memd[ds, eax + 206]);          /* mov eax, [eax+0xce] */
            ii(0x1012_d9dd, 5); call(0x100c_f85c, -0x5_e186);           /* call 0x100cf85c */
            ii(0x1012_d9e2, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_d9e7, 5); call(Definitions.sys_new, 0x3_8414);    /* call 0x10165e00 */
            ii(0x1012_d9ec, 6); mov(memd[ss, ebp - 220], eax);          /* mov [ebp-0xdc], eax */
            ii(0x1012_d9f2, 6); mov(eax, memd[ss, ebp - 220]);          /* mov eax, [ebp-0xdc] */
            ii(0x1012_d9f8, 6); mov(memd[ss, ebp - 224], eax);          /* mov [ebp-0xe0], eax */
            ii(0x1012_d9fe, 7); cmp(memd[ss, ebp - 224], 0);            /* cmp dword [ebp-0xe0], 0x0 */
            ii(0x1012_da05, 2); if(jz(0x1012_da3b, 0x34)) goto l_0x1012_da3b; /* jz 0x1012da3b */
            ii(0x1012_da07, 5); mov(eax, 0x1aa);                        /* mov eax, 0x1aa */
            ii(0x1012_da0c, 1); push(eax);                              /* push eax */
            ii(0x1012_da0d, 5); mov(ecx, 0x204);                        /* mov ecx, 0x204 */
            ii(0x1012_da12, 5); mov(ebx, 0x196);                        /* mov ebx, 0x196 */
            ii(0x1012_da17, 5); mov(edx, 0x195);                        /* mov edx, 0x195 */
            ii(0x1012_da1c, 6); mov(eax, memd[ss, ebp - 220]);          /* mov eax, [ebp-0xdc] */
            ii(0x1012_da22, 5); call(Definitions.my_ctor_c17, -0x5_f618); /* call 0x100ce40f */
            ii(0x1012_da27, 6); mov(memd[ss, ebp - 228], eax);          /* mov [ebp-0xe4], eax */
            ii(0x1012_da2d, 6); mov(eax, memd[ss, ebp - 228]);          /* mov eax, [ebp-0xe4] */
            ii(0x1012_da33, 6); mov(memd[ss, ebp - 132], eax);          /* mov [ebp-0x84], eax */
            ii(0x1012_da39, 2); jmp(0x1012_da47, 0xc); goto l_0x1012_da47; /* jmp 0x1012da47 */
        l_0x1012_da3b:
            ii(0x1012_da3b, 6); mov(eax, memd[ss, ebp - 224]);          /* mov eax, [ebp-0xe0] */
            ii(0x1012_da41, 6); mov(memd[ss, ebp - 132], eax);          /* mov [ebp-0x84], eax */
        l_0x1012_da47:
            ii(0x1012_da47, 6); mov(eax, memd[ss, ebp - 132]);          /* mov eax, [ebp-0x84] */
            ii(0x1012_da4d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_da50, 6); mov(memd[ds, edx + 210], eax);          /* mov [edx+0xd2], eax */
            ii(0x1012_da56, 5); mov(edx, 0x197);                        /* mov edx, 0x197 */
            ii(0x1012_da5b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_da5e, 6); mov(eax, memd[ds, eax + 210]);          /* mov eax, [eax+0xd2] */
            ii(0x1012_da64, 5); call(0x100c_f2ba, -0x5_e7af);           /* call 0x100cf2ba */
            ii(0x1012_da69, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_da6f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_da72, 6); mov(eax, memd[ds, eax + 210]);          /* mov eax, [eax+0xd2] */
            ii(0x1012_da78, 5); call(0x100c_e92d, -0x5_f150);           /* call 0x100ce92d */
            ii(0x1012_da7d, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_da80, 5); mov(edx, 0x1013_14bc);                  /* mov edx, 0x101314bc */
            ii(0x1012_da85, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_da88, 6); mov(eax, memd[ds, eax + 210]);          /* mov eax, [eax+0xd2] */
            ii(0x1012_da8e, 5); call(0x100c_f824, -0x5_e26f);           /* call 0x100cf824 */
            ii(0x1012_da93, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_da98, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_da9b, 6); mov(eax, memd[ds, eax + 210]);          /* mov eax, [eax+0xd2] */
            ii(0x1012_daa1, 5); call(0x100d_50d4, -0x5_89d2);           /* call 0x100d50d4 */
            ii(0x1012_daa6, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_daac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_daaf, 6); mov(eax, memd[ds, eax + 210]);          /* mov eax, [eax+0xd2] */
            ii(0x1012_dab5, 5); call(0x100c_f85c, -0x5_e25e);           /* call 0x100cf85c */
            ii(0x1012_daba, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_dabf, 5); call(Definitions.sys_new, 0x3_833c);    /* call 0x10165e00 */
            ii(0x1012_dac4, 6); mov(memd[ss, ebp - 208], eax);          /* mov [ebp-0xd0], eax */
            ii(0x1012_daca, 6); mov(eax, memd[ss, ebp - 208]);          /* mov eax, [ebp-0xd0] */
            ii(0x1012_dad0, 6); mov(memd[ss, ebp - 212], eax);          /* mov [ebp-0xd4], eax */
            ii(0x1012_dad6, 7); cmp(memd[ss, ebp - 212], 0);            /* cmp dword [ebp-0xd4], 0x0 */
            ii(0x1012_dadd, 2); if(jz(0x1012_db10, 0x31)) goto l_0x1012_db10; /* jz 0x1012db10 */
            ii(0x1012_dadf, 5); mov(eax, 0x18e);                        /* mov eax, 0x18e */
            ii(0x1012_dae4, 1); push(eax);                              /* push eax */
            ii(0x1012_dae5, 5); mov(ecx, 0x1fd);                        /* mov ecx, 0x1fd */
            ii(0x1012_daea, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x1012_daef, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x1012_daf4, 6); mov(eax, memd[ss, ebp - 208]);          /* mov eax, [ebp-0xd0] */
            ii(0x1012_dafa, 5); call(Definitions.my_ctor_c17, -0x5_f6f0); /* call 0x100ce40f */
            ii(0x1012_daff, 6); mov(memd[ss, ebp - 216], eax);          /* mov [ebp-0xd8], eax */
            ii(0x1012_db05, 6); mov(eax, memd[ss, ebp - 216]);          /* mov eax, [ebp-0xd8] */
            ii(0x1012_db0b, 3); mov(memd[ss, ebp - 128], eax);          /* mov [ebp-0x80], eax */
            ii(0x1012_db0e, 2); jmp(0x1012_db19, 9); goto l_0x1012_db19; /* jmp 0x1012db19 */
        l_0x1012_db10:
            ii(0x1012_db10, 6); mov(eax, memd[ss, ebp - 212]);          /* mov eax, [ebp-0xd4] */
            ii(0x1012_db16, 3); mov(memd[ss, ebp - 128], eax);          /* mov [ebp-0x80], eax */
        l_0x1012_db19:
            ii(0x1012_db19, 3); mov(eax, memd[ss, ebp - 128]);          /* mov eax, [ebp-0x80] */
            ii(0x1012_db1c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_db1f, 6); mov(memd[ds, edx + 214], eax);          /* mov [edx+0xd6], eax */
            ii(0x1012_db25, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_db2b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_db2e, 6); mov(eax, memd[ds, eax + 214]);          /* mov eax, [eax+0xd6] */
            ii(0x1012_db34, 5); call(0x100c_e92d, -0x5_f20c);           /* call 0x100ce92d */
            ii(0x1012_db39, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1012_db3c, 5); call(0x100e_0ba4, -0x4_cf9d);           /* call 0x100e0ba4 */
            ii(0x1012_db41, 1); push(eax);                              /* push eax */
            ii(0x1012_db42, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1012_db45, 5); call(0x100e_0bd0, -0x4_cf7a);           /* call 0x100e0bd0 */
            ii(0x1012_db4a, 1); push(eax);                              /* push eax */
            ii(0x1012_db4b, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1012_db4e, 5); call(0x100e_0bfc, -0x4_cf57);           /* call 0x100e0bfc */
            ii(0x1012_db53, 1); push(eax);                              /* push eax */
            ii(0x1012_db54, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x1012_db57, 5); call(0x100e_0c28, -0x4_cf34);           /* call 0x100e0c28 */
            ii(0x1012_db5c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_db5e, 6); lea(ebx, memd[ss, ebp - 432]);          /* lea ebx, [ebp-0x1b0] */
            ii(0x1012_db64, 5); mov(edx, StringDefinitions.Done4);      /* mov edx, 0x101a87e6 */
            ii(0x1012_db69, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_db6c, 6); mov(eax, memd[ds, eax + 214]);          /* mov eax, [eax+0xd6] */
            ii(0x1012_db72, 5); call(0x100c_edcd, -0x5_edaa);           /* call 0x100cedcd */
            ii(0x1012_db77, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1012_db7c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_db7f, 6); mov(eax, memd[ds, eax + 214]);          /* mov eax, [eax+0xd6] */
            ii(0x1012_db85, 5); call(0x100d_5134, -0x5_8a56);           /* call 0x100d5134 */
            ii(0x1012_db8a, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_db8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_db92, 6); mov(eax, memd[ds, eax + 214]);          /* mov eax, [eax+0xd6] */
            ii(0x1012_db98, 5); call(0x100d_50d4, -0x5_8ac9);           /* call 0x100d50d4 */
            ii(0x1012_db9d, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_dba3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dba6, 6); mov(eax, memd[ds, eax + 214]);          /* mov eax, [eax+0xd6] */
            ii(0x1012_dbac, 5); call(0x100c_f85c, -0x5_e355);           /* call 0x100cf85c */
            ii(0x1012_dbb1, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_dbb6, 5); call(Definitions.sys_new, 0x3_8245);    /* call 0x10165e00 */
            ii(0x1012_dbbb, 6); mov(memd[ss, ebp - 196], eax);          /* mov [ebp-0xc4], eax */
            ii(0x1012_dbc1, 6); mov(eax, memd[ss, ebp - 196]);          /* mov eax, [ebp-0xc4] */
            ii(0x1012_dbc7, 6); mov(memd[ss, ebp - 200], eax);          /* mov [ebp-0xc8], eax */
            ii(0x1012_dbcd, 7); cmp(memd[ss, ebp - 200], 0);            /* cmp dword [ebp-0xc8], 0x0 */
            ii(0x1012_dbd4, 2); if(jz(0x1012_dc0a, 0x34)) goto l_0x1012_dc0a; /* jz 0x1012dc0a */
            ii(0x1012_dbd6, 5); mov(eax, 0x1ab);                        /* mov eax, 0x1ab */
            ii(0x1012_dbdb, 1); push(eax);                              /* push eax */
            ii(0x1012_dbdc, 5); mov(ecx, 0x21f);                        /* mov ecx, 0x21f */
            ii(0x1012_dbe1, 5); mov(ebx, 0x199);                        /* mov ebx, 0x199 */
            ii(0x1012_dbe6, 5); mov(edx, 0x198);                        /* mov edx, 0x198 */
            ii(0x1012_dbeb, 6); mov(eax, memd[ss, ebp - 196]);          /* mov eax, [ebp-0xc4] */
            ii(0x1012_dbf1, 5); call(Definitions.my_ctor_c17, -0x5_f7e7); /* call 0x100ce40f */
            ii(0x1012_dbf6, 6); mov(memd[ss, ebp - 204], eax);          /* mov [ebp-0xcc], eax */
            ii(0x1012_dbfc, 6); mov(eax, memd[ss, ebp - 204]);          /* mov eax, [ebp-0xcc] */
            ii(0x1012_dc02, 6); mov(memd[ss, ebp - 140], eax);          /* mov [ebp-0x8c], eax */
            ii(0x1012_dc08, 2); jmp(0x1012_dc16, 0xc); goto l_0x1012_dc16; /* jmp 0x1012dc16 */
        l_0x1012_dc0a:
            ii(0x1012_dc0a, 6); mov(eax, memd[ss, ebp - 200]);          /* mov eax, [ebp-0xc8] */
            ii(0x1012_dc10, 6); mov(memd[ss, ebp - 140], eax);          /* mov [ebp-0x8c], eax */
        l_0x1012_dc16:
            ii(0x1012_dc16, 6); mov(eax, memd[ss, ebp - 140]);          /* mov eax, [ebp-0x8c] */
            ii(0x1012_dc1c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_dc1f, 6); mov(memd[ds, edx + 218], eax);          /* mov [edx+0xda], eax */
            ii(0x1012_dc25, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1012_dc28, 5); mov(edx, 0x1013_168d);                  /* mov edx, 0x1013168d */
            ii(0x1012_dc2d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc30, 6); mov(eax, memd[ds, eax + 218]);          /* mov eax, [eax+0xda] */
            ii(0x1012_dc36, 5); call(0x100c_f824, -0x5_e417);           /* call 0x100cf824 */
            ii(0x1012_dc3b, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_dc40, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc43, 6); mov(eax, memd[ds, eax + 218]);          /* mov eax, [eax+0xda] */
            ii(0x1012_dc49, 5); call(0x100d_50d4, -0x5_8b7a);           /* call 0x100d50d4 */
            ii(0x1012_dc4e, 6); mov(edx, memd[ss, ebp - 442]);          /* mov edx, [ebp-0x1ba] */
            ii(0x1012_dc54, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc57, 6); mov(eax, memd[ds, eax + 218]);          /* mov eax, [eax+0xda] */
            ii(0x1012_dc5d, 5); call(0x100c_f85c, -0x5_e406);           /* call 0x100cf85c */
            ii(0x1012_dc62, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc65, 4); mov(memb[ds, eax + 23], 0);             /* mov byte [eax+0x17], 0x0 */
            ii(0x1012_dc69, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc6c, 5); call(0x1012_f003, 0x1392);              /* call 0x1012f003 */
            ii(0x1012_dc71, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc74, 5); call(0x1012_eca4, 0x102b);              /* call 0x1012eca4 */
            ii(0x1012_dc79, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_dc7e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc81, 5); call(0x1013_0c16, 0x2f90);              /* call 0x10130c16 */
            ii(0x1012_dc86, 6); mov(eax, memd[ss, ebp - 442]);          /* mov eax, [ebp-0x1ba] */
            ii(0x1012_dc8c, 5); call(Definitions.sys_display_draw_0, 0x3_97f3); /* call 0x10167484 */
            ii(0x1012_dc91, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_dc96, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dc99, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_dc9f, 5); call(0x100c_fb73, -0x5_e131);           /* call 0x100cfb73 */
            ii(0x1012_dca4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dca6, 6); mov(dl, memb[ds, 0x101b_b48c]);         /* mov dl, [0x101bb48c] */
            ii(0x1012_dcac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dcaf, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_dcb5, 5); call(0x100c_fb73, -0x5_e147);           /* call 0x100cfb73 */
            ii(0x1012_dcba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dcbc, 6); mov(dl, memb[ds, 0x101b_b48d]);         /* mov dl, [0x101bb48d] */
            ii(0x1012_dcc2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dcc5, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_dccb, 5); call(0x100c_fb73, -0x5_e15d);           /* call 0x100cfb73 */
            ii(0x1012_dcd0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dcd2, 6); mov(dl, memb[ds, 0x101b_b48e]);         /* mov dl, [0x101bb48e] */
            ii(0x1012_dcd8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dcdb, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_dce1, 5); call(0x100c_fb73, -0x5_e173);           /* call 0x100cfb73 */
            ii(0x1012_dce6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dce8, 6); mov(dl, memb[ds, 0x101b_b48f]);         /* mov dl, [0x101bb48f] */
            ii(0x1012_dcee, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dcf1, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_dcf7, 5); call(0x100c_fb73, -0x5_e189);           /* call 0x100cfb73 */
            ii(0x1012_dcfc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dcfe, 6); mov(dl, memb[ds, 0x101c_61b0]);         /* mov dl, [0x101c61b0] */
            ii(0x1012_dd04, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dd07, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_dd0d, 5); call(0x100c_fb73, -0x5_e19f);           /* call 0x100cfb73 */
            ii(0x1012_dd12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dd14, 6); mov(dl, memb[ds, 0x101c_61b1]);         /* mov dl, [0x101c61b1] */
            ii(0x1012_dd1a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dd1d, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_dd23, 5); call(0x100c_fb73, -0x5_e1b5);           /* call 0x100cfb73 */
            ii(0x1012_dd28, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dd2a, 6); mov(dl, memb[ds, 0x101c_61b2]);         /* mov dl, [0x101c61b2] */
            ii(0x1012_dd30, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dd33, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_dd39, 5); call(0x100c_fb73, -0x5_e1cb);           /* call 0x100cfb73 */
            ii(0x1012_dd3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dd40, 6); mov(dl, memb[ds, 0x101c_61b3]);         /* mov dl, [0x101c61b3] */
            ii(0x1012_dd46, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dd49, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_dd4f, 5); call(0x100c_fb73, -0x5_e1e1);           /* call 0x100cfb73 */
            ii(0x1012_dd54, 5); call(/* sys */ 0x1016_bcc4, 0x3_df6b);  /* call 0x1016bcc4 */
            ii(0x1012_dd59, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_dd5c, 6); mov(memd[ss, ebp - 480], eax);          /* mov [ebp-0x1e0], eax */
            ii(0x1012_dd62, 6); mov(eax, memd[ss, ebp - 480]);          /* mov eax, [ebp-0x1e0] */
            ii(0x1012_dd68, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_dd6a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_dd6b, 1); pop(edi);                               /* pop edi */
            ii(0x1012_dd6c, 1); pop(esi);                               /* pop esi */
            ii(0x1012_dd6d, 1); pop(edx);                               /* pop edx */
            ii(0x1012_dd6e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_dd6f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_dd70, 1); ret();                                  /* ret */
        }
    }
}
