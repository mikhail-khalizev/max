using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_008a-47903231")]
        public void Method_100f_008a()
        {
            ii(0x100f_008a, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100f_008f, 5);  call(Definitions.sys_check_available_stack_size, 0x7_5cbe);/* call 0x10165d52 */
            ii(0x100f_0094, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_0095, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_0096, 1);  push(esi);                            /* push esi */
            ii(0x100f_0097, 1);  push(edi);                            /* push edi */
            ii(0x100f_0098, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_0099, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_009b, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100f_00a1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_00a4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_00a7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_00aa, 4);  cmp(memd[ds, eax + 8], 0);            /* cmp dword [eax+0x8], 0x0 */
            ii(0x100f_00ae, 2);  if(jz(0x100f_00c5, 0x15)) goto l_0x100f_00c5;/* jz 0x100f00c5 */
            ii(0x100f_00b0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_00b3, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_00b6, 5);  call(Definitions.sys_free, 0x7_b006); /* call 0x1016b0c1 */
            ii(0x100f_00bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_00be, 7);  mov(memd[ds, eax + 8], 0);            /* mov dword [eax+0x8], 0x0 */
        l_0x100f_00c5:
            ii(0x100f_00c5, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_00c9, 2);  if(jz(0x100f_00d4, 9)) goto l_0x100f_00d4;/* jz 0x100f00d4 */
            ii(0x100f_00cb, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_00d2, 2);  jmp(0x100f_00ed, 0x19); goto l_0x100f_00ed;/* jmp 0x100f00ed */
        l_0x100f_00d4:
            ii(0x100f_00d4, 5);  mov(ecx, 0x115);                      /* mov ecx, 0x115 */
            ii(0x100f_00d9, 5);  mov(ebx, StringDefinitions.FlicsmgrCpp2);/* mov ebx, 0x101a220c */
            ii(0x100f_00de, 5);  mov(edx, StringDefinitions.FileNotEqual0);/* mov edx, 0x101a2219 */
            ii(0x100f_00e3, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_00e5, 5);  call(Definitions.sys_assert, 0x7_5ca8);/* call 0x10165d92 */
            ii(0x100f_00ea, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x100f_00ed:
            ii(0x100f_00ed, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x100f_00f0, 5);  mov(ebx, 0x10);                       /* mov ebx, 0x10 */
            ii(0x100f_00f5, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100f_00fa, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_00fd, 5);  call(Definitions.my_fread, -0xc73);   /* call 0x100ef48f */
            ii(0x100f_0102, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_0104, 2);  if(jnz(0x100f_010f, 9)) goto l_0x100f_010f;/* jnz 0x100f010f */
            ii(0x100f_0106, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_010a, 5);  jmp(0x100f_01b0, 0xa1); goto l_0x100f_01b0;/* jmp 0x100f01b0 */
        l_0x100f_010f:
            ii(0x100f_010f, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100f_0112, 3);  sub(eax, 0x10);                       /* sub eax, 0x10 */
            ii(0x100f_0115, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_0118, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x100f_011a, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_011d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_0120, 4);  mov(memw[ds, edx + 4], ax);           /* mov [edx+0x4], ax */
            ii(0x100f_0124, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0127, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x100f_012b, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x100f_0130, 5);  cmp(eax, 0xf1fa);                     /* cmp eax, 0xf1fa */
            ii(0x100f_0135, 2);  if(jnz(0x100f_0140, 9)) goto l_0x100f_0140;/* jnz 0x100f0140 */
            ii(0x100f_0137, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x100f_013e, 2);  jmp(0x100f_0159, 0x19); goto l_0x100f_0159;/* jmp 0x100f0159 */
        l_0x100f_0140:
            ii(0x100f_0140, 5);  mov(ecx, 0x11a);                      /* mov ecx, 0x11a */
            ii(0x100f_0145, 5);  mov(ebx, StringDefinitions.FlicsmgrCpp);/* mov ebx, 0x101a2223 */
            ii(0x100f_014a, 5);  mov(edx, StringDefinitions.FrameTypeEqual0xf1fa);/* mov edx, 0x101a2230 */
            ii(0x100f_014f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_0151, 5);  call(Definitions.sys_assert, 0x7_5c3c);/* call 0x10165d92 */
            ii(0x100f_0156, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x100f_0159:
            ii(0x100f_0159, 3);  mov(eax, memd[ss, ebp - 26]);         /* mov eax, [ebp-0x1a] */
            ii(0x100f_015c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_015f, 4);  mov(memw[ds, edx + 6], ax);           /* mov [edx+0x6], ax */
            ii(0x100f_0163, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0166, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_0168, 5);  call(Definitions.sys_malloc, 0x7_ae71);/* call 0x1016afde */
            ii(0x100f_016d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_016f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0172, 3);  mov(memd[ds, eax + 8], edx);          /* mov [eax+0x8], edx */
            ii(0x100f_0175, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x100f_0178, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_017b, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x100f_017d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100f_0182, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0185, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_0188, 5);  call(Definitions.my_fread, -0xcfe);   /* call 0x100ef48f */
            ii(0x100f_018d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_018f, 2);  if(jnz(0x100f_01ac, 0x1b)) goto l_0x100f_01ac;/* jnz 0x100f01ac */
            ii(0x100f_0191, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0194, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_0197, 5);  call(Definitions.sys_free, 0x7_af25); /* call 0x1016b0c1 */
            ii(0x100f_019c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_019f, 7);  mov(memd[ds, eax + 8], 0);            /* mov dword [eax+0x8], 0x0 */
            ii(0x100f_01a6, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_01aa, 2);  jmp(0x100f_01b0, 4); goto l_0x100f_01b0;/* jmp 0x100f01b0 */
        l_0x100f_01ac:
            ii(0x100f_01ac, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
        l_0x100f_01b0:
            ii(0x100f_01b0, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100f_01b3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_01b5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_01b6, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_01b7, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_01b8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_01b9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_01ba, 1);  ret();                                /* ret */
        }
    }
}
