using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_61a2-355b89ae")]
        public void Method_1011_61a2()
        {
            ii(0x1011_61a2, 5);  push(0x90);                           /* push 0x90 */
            ii(0x1011_61a7, 5);  call(Definitions.sys_check_available_stack_size, 0x4_fba6);/* call 0x10165d52 */
            ii(0x1011_61ac, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_61ad, 1);  push(esi);                            /* push esi */
            ii(0x1011_61ae, 1);  push(edi);                            /* push edi */
            ii(0x1011_61af, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_61b0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_61b2, 6);  sub(esp, 0x6c);                       /* sub esp, 0x6c */
            ii(0x1011_61b8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_61bb, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_61be, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1011_61c1, 7);  cmp(memb[ds, 0x101c_391e], 3);        /* cmp byte [0x101c391e], 0x3 */
            ii(0x1011_61c8, 2);  if(jnz(0x1011_61d0, 6)) goto l_0x1011_61d0;/* jnz 0x101161d0 */
            ii(0x1011_61ca, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_61ce, 2);  jmp(0x1011_61d4, 4); goto l_0x1011_61d4;/* jmp 0x101161d4 */
        l_0x1011_61d0:
            ii(0x1011_61d0, 4);  mov(memb[ss, ebp - 16], 0x26);        /* mov byte [ebp-0x10], 0x26 */
        l_0x1011_61d4:
            ii(0x1011_61d4, 3);  mov(ebx, memd[ss, ebp - 19]);         /* mov ebx, [ebp-0x13] */
            ii(0x1011_61d7, 3);  sar(ebx, 0x18);                       /* sar ebx, 0x18 */
            ii(0x1011_61da, 5);  mov(edx, 0x6e6);                      /* mov edx, 0x6e6 */
            ii(0x1011_61df, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_61e2, 5);  call(0x100d_68a3, -0x3_f944);         /* call 0x100d68a3 */
            ii(0x1011_61e7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_61ea, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1011_61ed, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_61f0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_61f3, 7);  mov(memd[ds, eax + 19], 0x101b_6744); /* mov dword [eax+0x13], 0x101b6744 */
            ii(0x1011_61fa, 7);  cmp(memb[ds, 0x101c_391e], 3);        /* cmp byte [0x101c391e], 0x3 */
            ii(0x1011_6201, 2);  if(jz(0x1011_6209, 6)) goto l_0x1011_6209;/* jz 0x10116209 */
            ii(0x1011_6203, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_6207, 2);  jmp(0x1011_620d, 4); goto l_0x1011_620d;/* jmp 0x1011620d */
        l_0x1011_6209:
            ii(0x1011_6209, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1011_620d:
            ii(0x1011_620d, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1011_6210, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_6213, 3);  mov(memb[ds, edx + 62], al);          /* mov [edx+0x3e], al */
            ii(0x1011_6216, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1011_621b, 5);  call(0x1012_0d94, 0xab74);            /* call 0x10120d94 */
            ii(0x1011_6220, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1011_6225, 5);  call(/* sys */ 0x1016_a24c, 0x5_4022);/* call 0x1016a24c */
            ii(0x1011_622a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_622d, 7);  mov(memd[ds, eax + 69], 0);           /* mov dword [eax+0x45], 0x0 */
            ii(0x1011_6234, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6237, 6);  mov(memw[ds, eax + 77], 0);           /* mov word [eax+0x4d], 0x0 */
            ii(0x1011_623d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6240, 7);  mov(memd[ds, eax + 54], 0);           /* mov dword [eax+0x36], 0x0 */
            ii(0x1011_6247, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_624a, 7);  mov(memd[ds, eax + 58], 0);           /* mov dword [eax+0x3a], 0x0 */
            ii(0x1011_6251, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_6254, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_6257, 3);  mov(memb[ds, edx + 64], al);          /* mov [edx+0x40], al */
            ii(0x1011_625a, 5);  mov(edx, 0x10);                       /* mov edx, 0x10 */
            ii(0x1011_625f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6262, 5);  call(0x100e_f318, -0x2_6f4f);         /* call 0x100ef318 */
            ii(0x1011_6267, 5);  call(0x100d_6124, -0x4_0148);         /* call 0x100d6124 */
            ii(0x1011_626c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_626e, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1011_6270, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6273, 5);  call(0x100d_6adf, -0x3_f799);         /* call 0x100d6adf */
            ii(0x1011_6278, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_627b, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1011_627e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6281, 5);  call(0x100d_6a11, -0x3_f875);         /* call 0x100d6a11 */
            ii(0x1011_6286, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x1011_628b, 5);  call(Definitions.sys_new, 0x4_fb70);  /* call 0x10165e00 */
            ii(0x1011_6290, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_6293, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_6296, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_6299, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1011_629d, 2);  if(jz(0x1011_62c7, 0x28)) goto l_0x1011_62c7;/* jz 0x101162c7 */
            ii(0x1011_629f, 5);  mov(eax, 0xaf);                       /* mov eax, 0xaf */
            ii(0x1011_62a4, 1);  push(eax);                            /* push eax */
            ii(0x1011_62a5, 5);  mov(ecx, 0x109);                      /* mov ecx, 0x109 */
            ii(0x1011_62aa, 5);  mov(ebx, 0xe);                        /* mov ebx, 0xe */
            ii(0x1011_62af, 5);  mov(edx, 0x14);                       /* mov edx, 0x14 */
            ii(0x1011_62b4, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_62b7, 5);  call(0x100d_7bdc, -0x3_e6e0);         /* call 0x100d7bdc */
            ii(0x1011_62bc, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_62bf, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_62c2, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_62c5, 2);  jmp(0x1011_62cd, 6); goto l_0x1011_62cd;/* jmp 0x101162cd */
        l_0x1011_62c7:
            ii(0x1011_62c7, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_62ca, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
        l_0x1011_62cd:
            ii(0x1011_62cd, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_62d0, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_62d3, 3);  mov(memd[ds, edx + 65], eax);         /* mov [edx+0x41], eax */
            ii(0x1011_62d6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_62d9, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1011_62dc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_62df, 3);  mov(eax, memd[ds, eax + 65]);         /* mov eax, [eax+0x41] */
            ii(0x1011_62e2, 5);  call(0x100d_7d74, -0x3_e573);         /* call 0x100d7d74 */
            ii(0x1011_62e7, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1011_62ec, 5);  call(Definitions.sys_new, 0x4_fb0f);  /* call 0x10165e00 */
            ii(0x1011_62f1, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_62f4, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_62f7, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1011_62fa, 4);  cmp(memd[ss, ebp - 48], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1011_62fe, 2);  if(jz(0x1011_6328, 0x28)) goto l_0x1011_6328;/* jz 0x10116328 */
            ii(0x1011_6300, 5);  mov(eax, 0xc1);                       /* mov eax, 0xc1 */
            ii(0x1011_6305, 1);  push(eax);                            /* push eax */
            ii(0x1011_6306, 5);  mov(ecx, 0x78);                       /* mov ecx, 0x78 */
            ii(0x1011_630b, 5);  mov(ebx, 0x159);                      /* mov ebx, 0x159 */
            ii(0x1011_6310, 5);  mov(edx, 0x158);                      /* mov edx, 0x158 */
            ii(0x1011_6315, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_6318, 5);  call(Definitions.my_ctor_c17, -0x4_7f0e);/* call 0x100ce40f */
            ii(0x1011_631d, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_6320, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_6323, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1011_6326, 2);  jmp(0x1011_632e, 6); goto l_0x1011_632e;/* jmp 0x1011632e */
        l_0x1011_6328:
            ii(0x1011_6328, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_632b, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
        l_0x1011_632e:
            ii(0x1011_632e, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_6331, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_6334, 3);  mov(memd[ds, edx + 50], eax);         /* mov [edx+0x32], eax */
            ii(0x1011_6337, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1011_633a, 5);  call(0x100d_5224, -0x4_111b);         /* call 0x100d5224 */
            ii(0x1011_633f, 1);  push(eax);                            /* push eax */
            ii(0x1011_6340, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1011_6343, 5);  call(0x100d_5250, -0x4_10f8);         /* call 0x100d5250 */
            ii(0x1011_6348, 1);  push(eax);                            /* push eax */
            ii(0x1011_6349, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1011_634c, 5);  call(0x100d_527c, -0x4_10d5);         /* call 0x100d527c */
            ii(0x1011_6351, 1);  push(eax);                            /* push eax */
            ii(0x1011_6352, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1011_6355, 5);  call(0x100d_52a8, -0x4_10b2);         /* call 0x100d52a8 */
            ii(0x1011_635a, 1);  push(eax);                            /* push eax */
            ii(0x1011_635b, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1011_6360, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1011_6365, 5);  mov(edx, StringDefinitions.Ok);       /* mov edx, 0x101a7aed */
            ii(0x1011_636a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_636d, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1011_6370, 5);  call(0x100c_ef64, -0x4_7411);         /* call 0x100cef64 */
            ii(0x1011_6375, 5);  mov(edx, 0xd);                        /* mov edx, 0xd */
            ii(0x1011_637a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_637d, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1011_6380, 5);  call(0x100d_5134, -0x4_1251);         /* call 0x100d5134 */
            ii(0x1011_6385, 5);  mov(edx, 0x700d);                     /* mov edx, 0x700d */
            ii(0x1011_638a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_638d, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1011_6390, 5);  call(0x100d_5164, -0x4_1231);         /* call 0x100d5164 */
            ii(0x1011_6395, 5);  mov(edx, 0x4e6);                      /* mov edx, 0x4e6 */
            ii(0x1011_639a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_639d, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1011_63a0, 5);  call(0x100d_50d4, -0x4_12d1);         /* call 0x100d50d4 */
            ii(0x1011_63a5, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_63a8, 3);  mov(edx, memd[ds, edx + 41]);         /* mov edx, [edx+0x29] */
            ii(0x1011_63ab, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_63ae, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1011_63b1, 5);  call(0x100c_f85c, -0x4_6b5a);         /* call 0x100cf85c */
            ii(0x1011_63b6, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1011_63bc, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1011_63be, 5);  mov(eax, 0xaf);                       /* mov eax, 0xaf */
            ii(0x1011_63c3, 5);  mov(edx, 0xaf);                       /* mov edx, 0xaf */
            ii(0x1011_63c8, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_63cb, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1011_63cd, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_63d0, 4);  mov(memw[ds, edx + 75], ax);          /* mov [edx+0x4b], ax */
            ii(0x1011_63d4, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x1011_63d7, 3);  add(ecx, 0x49);                       /* add ecx, 0x49 */
            ii(0x1011_63da, 5);  mov(ebx, 0x109);                      /* mov ebx, 0x109 */
            ii(0x1011_63df, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_63e2, 5);  imul(ax, memw[ds, eax + 75], 3);      /* imul ax, [eax+0x4b], 0x3 */
            ii(0x1011_63e7, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_63ea, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_63ed, 5);  call(0x100e_969d, -0x2_cd55);         /* call 0x100e969d */
            ii(0x1011_63f2, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_63f5, 3);  mov(memd[ds, edx + 69], eax);         /* mov [edx+0x45], eax */
            ii(0x1011_63f8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_63fb, 4);  mov(dx, memw[ds, eax + 73]);          /* mov dx, [eax+0x49] */
            ii(0x1011_63ff, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6402, 4);  cmp(dx, memw[ds, eax + 75]);          /* cmp dx, [eax+0x4b] */
            ii(0x1011_6406, 6);  if(jle(0x1011_651e, 0x112)) goto l_0x1011_651e;/* jle 0x1011651e */
            ii(0x1011_640c, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1011_6411, 5);  call(Definitions.sys_new, 0x4_f9ea);  /* call 0x10165e00 */
            ii(0x1011_6416, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1011_6419, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1011_641c, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1011_641f, 4);  cmp(memd[ss, ebp - 80], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1011_6423, 2);  if(jz(0x1011_644d, 0x28)) goto l_0x1011_644d;/* jz 0x1011644d */
            ii(0x1011_6425, 5);  mov(eax, 0xc5);                       /* mov eax, 0xc5 */
            ii(0x1011_642a, 1);  push(eax);                            /* push eax */
            ii(0x1011_642b, 5);  mov(ecx, 0x14);                       /* mov ecx, 0x14 */
            ii(0x1011_6430, 5);  mov(ebx, 0x11b);                      /* mov ebx, 0x11b */
            ii(0x1011_6435, 5);  mov(edx, 0x11a);                      /* mov edx, 0x11a */
            ii(0x1011_643a, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1011_643d, 5);  call(Definitions.my_ctor_c17, -0x4_8033);/* call 0x100ce40f */
            ii(0x1011_6442, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1011_6445, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1011_6448, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x1011_644b, 2);  jmp(0x1011_6453, 6); goto l_0x1011_6453;/* jmp 0x10116453 */
        l_0x1011_644d:
            ii(0x1011_644d, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1011_6450, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
        l_0x1011_6453:
            ii(0x1011_6453, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x1011_6456, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_6459, 3);  mov(memd[ds, edx + 54], eax);         /* mov [edx+0x36], eax */
            ii(0x1011_645c, 5);  mov(edx, 0x3e8);                      /* mov edx, 0x3e8 */
            ii(0x1011_6461, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6464, 3);  mov(eax, memd[ds, eax + 54]);         /* mov eax, [eax+0x36] */
            ii(0x1011_6467, 5);  call(0x100d_5134, -0x4_1338);         /* call 0x100d5134 */
            ii(0x1011_646c, 5);  mov(edx, 0x73e8);                     /* mov edx, 0x73e8 */
            ii(0x1011_6471, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6474, 3);  mov(eax, memd[ds, eax + 54]);         /* mov eax, [eax+0x36] */
            ii(0x1011_6477, 5);  call(0x100d_5164, -0x4_1318);         /* call 0x100d5164 */
            ii(0x1011_647c, 5);  mov(edx, 0x4ff);                      /* mov edx, 0x4ff */
            ii(0x1011_6481, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6484, 3);  mov(eax, memd[ds, eax + 54]);         /* mov eax, [eax+0x36] */
            ii(0x1011_6487, 5);  call(0x100d_50d4, -0x4_13b8);         /* call 0x100d50d4 */
            ii(0x1011_648c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_648f, 3);  mov(edx, memd[ds, eax + 41]);         /* mov edx, [eax+0x29] */
            ii(0x1011_6492, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6495, 3);  mov(eax, memd[ds, eax + 54]);         /* mov eax, [eax+0x36] */
            ii(0x1011_6498, 5);  call(0x100c_f85c, -0x4_6c41);         /* call 0x100cf85c */
            ii(0x1011_649d, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1011_64a2, 5);  call(Definitions.sys_new, 0x4_f959);  /* call 0x10165e00 */
            ii(0x1011_64a7, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1011_64aa, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x1011_64ad, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x1011_64b0, 4);  cmp(memd[ss, ebp - 96], 0);           /* cmp dword [ebp-0x60], 0x0 */
            ii(0x1011_64b4, 2);  if(jz(0x1011_64de, 0x28)) goto l_0x1011_64de;/* jz 0x101164de */
            ii(0x1011_64b6, 5);  mov(eax, 0xc5);                       /* mov eax, 0xc5 */
            ii(0x1011_64bb, 1);  push(eax);                            /* push eax */
            ii(0x1011_64bc, 5);  mov(ecx, 0x28);                       /* mov ecx, 0x28 */
            ii(0x1011_64c1, 5);  mov(ebx, 0x11e);                      /* mov ebx, 0x11e */
            ii(0x1011_64c6, 5);  mov(edx, 0x11d);                      /* mov edx, 0x11d */
            ii(0x1011_64cb, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x1011_64ce, 5);  call(Definitions.my_ctor_c17, -0x4_80c4);/* call 0x100ce40f */
            ii(0x1011_64d3, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x1011_64d6, 3);  mov(eax, memd[ss, ebp - 100]);        /* mov eax, [ebp-0x64] */
            ii(0x1011_64d9, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x1011_64dc, 2);  jmp(0x1011_64e4, 6); goto l_0x1011_64e4;/* jmp 0x101164e4 */
        l_0x1011_64de:
            ii(0x1011_64de, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x1011_64e1, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
        l_0x1011_64e4:
            ii(0x1011_64e4, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x1011_64e7, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_64ea, 3);  mov(memd[ds, edx + 58], eax);         /* mov [edx+0x3a], eax */
            ii(0x1011_64ed, 5);  mov(edx, 0x3e9);                      /* mov edx, 0x3e9 */
            ii(0x1011_64f2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_64f5, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x1011_64f8, 5);  call(0x100d_5134, -0x4_13c9);         /* call 0x100d5134 */
            ii(0x1011_64fd, 5);  mov(edx, 0x73e9);                     /* mov edx, 0x73e9 */
            ii(0x1011_6502, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6505, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x1011_6508, 5);  call(0x100d_5164, -0x4_13a9);         /* call 0x100d5164 */
            ii(0x1011_650d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6510, 3);  mov(edx, memd[ds, eax + 41]);         /* mov edx, [eax+0x29] */
            ii(0x1011_6513, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6516, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x1011_6519, 5);  call(0x100c_f85c, -0x4_6cc2);         /* call 0x100cf85c */
        l_0x1011_651e:
            ii(0x1011_651e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6521, 5);  call(0x1011_6695, 0x16f);             /* call 0x10116695 */
            ii(0x1011_6526, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6529, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x1011_652c, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1011_652f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_6531, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_6532, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_6533, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_6534, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_6535, 1);  ret();                                /* ret */
        }
    }
}
