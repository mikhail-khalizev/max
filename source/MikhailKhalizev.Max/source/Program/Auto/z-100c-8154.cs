using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8154-f5f016ba")]
        public void Method_100c_8154()
        {
            ii(0x100c_8154, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_8159, 5);  call(Definitions.sys_check_available_stack_size, 0x9_dbf4);/* call 0x10165d52 */
            ii(0x100c_815e, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_815f, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_8160, 1);  push(esi);                            /* push esi */
            ii(0x100c_8161, 1);  push(edi);                            /* push edi */
            ii(0x100c_8162, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_8163, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_8165, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_816b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_816e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_8171, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_8174, 3);  mov(edx, memd[ds, edx + 23]);         /* mov edx, [edx+0x17] */
            ii(0x100c_8177, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_817a, 3);  add(edx, memd[ds, eax + 15]);         /* add edx, [eax+0xf] */
            ii(0x100c_817d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_817f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_8182, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100c_8184, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100c_8186, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100c_8189, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_818c, 3);  mov(edx, memd[ds, edx + 19]);         /* mov edx, [edx+0x13] */
            ii(0x100c_818f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8192, 3);  add(edx, memd[ds, eax + 11]);         /* add edx, [eax+0xb] */
            ii(0x100c_8195, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_8197, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_819a, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100c_819c, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100c_819e, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100c_81a1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_81a4, 5);  call(0x1007_6aac, -0x5_16fd);         /* call 0x10076aac */
            ii(0x100c_81a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_81ac, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_81ae, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_81af, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_81b0, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_81b1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_81b2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_81b3, 1);  ret();                                /* ret */
        }
    }
}
