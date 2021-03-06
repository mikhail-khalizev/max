using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_833b-9aa54ff1")]
        public void Method_1011_833b()
        {
            ii(0x1011_833b, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_8340, 5);  call(Definitions.sys_check_available_stack_size, 0x4_da0d);/* call 0x10165d52 */
            ii(0x1011_8345, 1);  push(esi);                            /* push esi */
            ii(0x1011_8346, 1);  push(edi);                            /* push edi */
            ii(0x1011_8347, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_8348, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_834a, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1011_8350, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_8353, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1011_8356, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1011_8359, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1011_835c, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1011_8360, 1);  push(eax);                            /* push eax */
            ii(0x1011_8361, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1011_8365, 1);  push(eax);                            /* push eax */
            ii(0x1011_8366, 4);  movsx(ecx, memw[ss, ebp + 16]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1011_836a, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1011_836d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_8370, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8373, 5);  call(0x1011_8113, -0x265);            /* call 0x10118113 */
            ii(0x1011_8378, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_837b, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_837e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_8381, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8384, 7);  mov(memd[ds, eax + 2], 0x101b_696c);  /* mov dword [eax+0x2], 0x101b696c */
            ii(0x1011_838b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_838e, 3);  shl(edx, 0x16);                       /* shl edx, 0x16 */
            ii(0x1011_8391, 4);  movsx(ebx, memw[ss, ebp + 16]);       /* movsx ebx, word [ebp+0x10] */
            ii(0x1011_8395, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_8397, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_839a, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1011_839c, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_839f, 3);  mov(memd[ds, edx + 37], eax);         /* mov [edx+0x25], eax */
            ii(0x1011_83a2, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_83a5, 3);  shl(edx, 0x16);                       /* shl edx, 0x16 */
            ii(0x1011_83a8, 4);  movsx(ebx, memw[ss, ebp + 16]);       /* movsx ebx, word [ebp+0x10] */
            ii(0x1011_83ac, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_83ae, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_83b1, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1011_83b3, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_83b6, 3);  mov(memd[ds, edx + 41], eax);         /* mov [edx+0x29], eax */
            ii(0x1011_83b9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_83bc, 7);  mov(memd[ds, eax + 33], 0);           /* mov dword [eax+0x21], 0x0 */
            ii(0x1011_83c3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_83c6, 3);  mov(edx, memd[ds, eax + 33]);         /* mov edx, [eax+0x21] */
            ii(0x1011_83c9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_83cc, 3);  mov(memd[ds, eax + 29], edx);         /* mov [eax+0x1d], edx */
            ii(0x1011_83cf, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_83d2, 4);  mov(dx, memw[ds, eax + 22]);          /* mov dx, [eax+0x16] */
            ii(0x1011_83d6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_83d9, 4);  mov(memw[ds, eax + 25], dx);          /* mov [eax+0x19], dx */
            ii(0x1011_83dd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_83e0, 4);  mov(dx, memw[ds, eax + 24]);          /* mov dx, [eax+0x18] */
            ii(0x1011_83e4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_83e7, 4);  mov(memw[ds, eax + 27], dx);          /* mov [eax+0x1b], dx */
            ii(0x1011_83eb, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1011_83ee, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_83f1, 4);  mov(memw[ds, edx + 22], ax);          /* mov [edx+0x16], ax */
            ii(0x1011_83f5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_83f8, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1011_83fc, 2);  if(jz(0x1011_8415, 0x17)) goto l_0x1011_8415;/* jz 0x10118415 */
            ii(0x1011_83fe, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1011_8402, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_8406, 5);  call(0x1015_c339, 0x4_3f2e);          /* call 0x1015c339 */
            ii(0x1011_840b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_840d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8410, 3);  mov(memb[ds, eax + 24], dl);          /* mov [eax+0x18], dl */
            ii(0x1011_8413, 2);  jmp(0x1011_8421, 0xc); goto l_0x1011_8421;/* jmp 0x10118421 */
        l_0x1011_8415:
            ii(0x1011_8415, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_8418, 3);  mov(dl, memb[ds, eax + 41]);          /* mov dl, [eax+0x29] */
            ii(0x1011_841b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_841e, 3);  mov(memb[ds, eax + 24], dl);          /* mov [eax+0x18], dl */
        l_0x1011_8421:
            ii(0x1011_8421, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8424, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_8427, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_842a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_842c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_842d, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_842e, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_842f, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
