using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b64f-e05be5de")]
        public void Method_1011_b64f()
        {
            ii(0x1011_b64f, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1011_b654, 5);  call(Definitions.sys_check_available_stack_size, 0x4_a6f9);/* call 0x10165d52 */
            ii(0x1011_b659, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_b65a, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_b65b, 1);  push(esi);                            /* push esi */
            ii(0x1011_b65c, 1);  push(edi);                            /* push edi */
            ii(0x1011_b65d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_b65e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_b660, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1011_b666, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_b669, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_b66c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b66f, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_b672, 5);  call(0x100b_82bc, -0x6_33bb);         /* call 0x100b82bc */
            ii(0x1011_b677, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_b67a, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_b681, 2);  jmp(0x1011_b689, 6); goto l_0x1011_b689;/* jmp 0x1011b689 */
        l_0x1011_b683:
            ii(0x1011_b683, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_b686, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1011_b689:
            ii(0x1011_b689, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_b68c, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1011_b690, 2);  if(jge(0x1011_b6b2, 0x20)) goto l_0x1011_b6b2;/* jge 0x1011b6b2 */
            ii(0x1011_b692, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_b696, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b699, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_b69c, 5);  call(0x100b_827c, -0x6_3425);         /* call 0x100b827c */
            ii(0x1011_b6a1, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_b6a5, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1011_b6a7, 3);  add(edx, memd[ss, ebp - 4]);          /* add edx, [ebp-0x4] */
            ii(0x1011_b6aa, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1011_b6ad, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1011_b6b0, 2);  jmp(0x1011_b683, -0x2f); goto l_0x1011_b683;/* jmp 0x1011b683 */
        l_0x1011_b6b2:
            ii(0x1011_b6b2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_b6b5, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_b6b8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_b6bb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_b6bd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_b6be, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_b6bf, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_b6c0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_b6c1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_b6c2, 1);  ret();                                /* ret */
        }
    }
}
