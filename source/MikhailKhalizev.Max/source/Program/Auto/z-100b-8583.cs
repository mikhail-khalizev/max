using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8583-5fb887a")]
        public void Method_100b_8583()
        {
            ii(0x100b_8583, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100b_8588, 5);  call(Definitions.sys_check_available_stack_size, 0xa_d7c5);/* call 0x10165d52 */
            ii(0x100b_858d, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_858e, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_858f, 1);  push(esi);                            /* push esi */
            ii(0x100b_8590, 1);  push(edi);                            /* push edi */
            ii(0x100b_8591, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_8592, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_8594, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100b_859a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_859d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_85a0, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100b_85a7, 2);  jmp(0x100b_85af, 6); goto l_0x100b_85af;/* jmp 0x100b85af */
        l_0x100b_85a9:
            ii(0x100b_85a9, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_85ac, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x100b_85af:
            ii(0x100b_85af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_85b2, 5);  call(0x1008_a4a0, -0x2_e117);         /* call 0x1008a4a0 */
            ii(0x100b_85b7, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x100b_85bb, 6);  if(jle(0x100b_8652, 0x91)) goto l_0x100b_8652;/* jle 0x100b8652 */
            ii(0x100b_85c1, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100b_85c5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_85c8, 5);  call(0x1008_a3dc, -0x2_e1f1);         /* call 0x1008a3dc */
            ii(0x100b_85cd, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100b_85d0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_85d3, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_85da, 2);  jmp(0x100b_85e2, 6); goto l_0x100b_85e2;/* jmp 0x100b85e2 */
        l_0x100b_85dc:
            ii(0x100b_85dc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_85df, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100b_85e2:
            ii(0x100b_85e2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_85e5, 5);  call(0x1008_a4a0, -0x2_e14a);         /* call 0x1008a4a0 */
            ii(0x100b_85ea, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100b_85ee, 2);  if(jle(0x100b_8605, 0x15)) goto l_0x100b_8605;/* jle 0x100b8605 */
            ii(0x100b_85f0, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100b_85f4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_85f7, 5);  call(0x1008_a3dc, -0x2_e220);         /* call 0x1008a3dc */
            ii(0x100b_85fc, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100b_85ff, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100b_8603, 2);  if(jnz(0x100b_85dc, -0x29)) goto l_0x100b_85dc;/* jnz 0x100b85dc */
        l_0x100b_8605:
            ii(0x100b_8605, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8608, 5);  call(0x1008_a4a0, -0x2_e16d);         /* call 0x1008a4a0 */
            ii(0x100b_860d, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100b_8611, 2);  if(jnz(0x100b_862b, 0x18)) goto l_0x100b_862b;/* jnz 0x100b862b */
            ii(0x100b_8613, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_8615, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100b_8619, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_861c, 5);  call(0x100b_8462, -0x1bf);            /* call 0x100b8462 */
            ii(0x100b_8621, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_8623, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8626, 5);  call(0x1008_a41c, -0x2_e20f);         /* call 0x1008a41c */
        l_0x100b_862b:
            ii(0x100b_862b, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100b_862f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8632, 5);  call(0x1008_a3dc, -0x2_e25b);         /* call 0x1008a3dc */
            ii(0x100b_8637, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100b_8639, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100b_863d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8640, 5);  call(0x1008_a3dc, -0x2_e269);         /* call 0x1008a3dc */
            ii(0x100b_8645, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x100b_8649, 4);  add(memw[ds, ebx + 2], ax);           /* add [ebx+0x2], ax */
            ii(0x100b_864d, 5);  jmp(0x100b_85a9, -0xa9); goto l_0x100b_85a9;/* jmp 0x100b85a9 */
        l_0x100b_8652:
            ii(0x100b_8652, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8655, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_8658, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_865b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_865d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_865e, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_865f, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_8660, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_8661, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_8662, 1);  ret();                                /* ret */
        }
    }
}
