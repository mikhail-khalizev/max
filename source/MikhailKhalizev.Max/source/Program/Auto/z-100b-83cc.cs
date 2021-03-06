using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_83cc-6e90db78")]
        public void Method_100b_83cc()
        {
            ii(0x100b_83cc, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100b_83d1, 5);  call(Definitions.sys_check_available_stack_size, 0xa_d97c);/* call 0x10165d52 */
            ii(0x100b_83d6, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_83d7, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_83d8, 1);  push(edx);                            /* push edx */
            ii(0x100b_83d9, 1);  push(esi);                            /* push esi */
            ii(0x100b_83da, 1);  push(edi);                            /* push edi */
            ii(0x100b_83db, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_83dc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_83de, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100b_83e4, 5);  mov(eax, 0x101b_77c0);                /* mov eax, 0x101b77c0 */
            ii(0x100b_83e9, 5);  call(/* sys */ 0x1016_611f, 0xa_dd31);/* call 0x1016611f */
            ii(0x100b_83ee, 5);  mov(ebx, 0x101b_5750);                /* mov ebx, 0x101b5750 */
            ii(0x100b_83f3, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x100b_83f8, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x100b_83fd, 5);  call(Definitions.sys_call_ctor_arr_v2, 0xa_db6e);/* call 0x10165f70 */
            ii(0x100b_8402, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_8405, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_8408, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_840b, 10);  mov(memd[ds, 0x101b_77c8], 1);       /* mov dword [0x101b77c8], 0x1 */
            ii(0x100b_8415, 5);  mov(eax, 0x101c_34d8);                /* mov eax, 0x101c34d8 */
            ii(0x100b_841a, 5);  call(0x100c_8a10, 0x1_05f1);          /* call 0x100c8a10 */
            ii(0x100b_841f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_8422, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_8425, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_8428, 10);  mov(memd[ds, 0x101b_77c8], 2);       /* mov dword [0x101b77c8], 0x2 */
            ii(0x100b_8432, 5);  mov(ebx, 0x101b_5724);                /* mov ebx, 0x101b5724 */
            ii(0x100b_8437, 5);  mov(edx, 0xa);                        /* mov edx, 0xa */
            ii(0x100b_843c, 5);  mov(eax, 0x101c_34e4);                /* mov eax, 0x101c34e4 */
            ii(0x100b_8441, 5);  call(Definitions.sys_call_ctor_arr_v2, 0xa_db2a);/* call 0x10165f70 */
            ii(0x100b_8446, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_8449, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_844c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_844f, 10);  mov(memd[ds, 0x101b_77c8], 3);       /* mov dword [0x101b77c8], 0x3 */
            ii(0x100b_8459, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_845b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_845c, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_845d, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_845e, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_845f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_8460, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_8461, 1);  ret();                                /* ret */
        }
    }
}
