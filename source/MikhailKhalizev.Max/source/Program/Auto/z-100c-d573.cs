using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d573-837957dd")]
        public void Method_100c_d573()
        {
            ii(0x100c_d573, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_d578, 5);  call(Definitions.sys_check_available_stack_size, 0x9_87d5);/* call 0x10165d52 */
            ii(0x100c_d57d, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_d57e, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_d57f, 1);  push(edx);                            /* push edx */
            ii(0x100c_d580, 1);  push(esi);                            /* push esi */
            ii(0x100c_d581, 1);  push(edi);                            /* push edi */
            ii(0x100c_d582, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_d583, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_d585, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_d58b, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_d58e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d591, 5);  call(0x100c_bb8b, -0x1a0b);           /* call 0x100cbb8b */
            ii(0x100c_d596, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_d599, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x100c_d59e, 2);  if(jz(0x100c_d5ac, 0xc)) goto l_0x100c_d5ac;/* jz 0x100cd5ac */
            ii(0x100c_d5a0, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_d5a4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d5a7, 5);  call(0x100c_bc91, -0x191b);           /* call 0x100cbc91 */
        l_0x100c_d5ac:
            ii(0x100c_d5ac, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_d5ae, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_d5af, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_d5b0, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_d5b1, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_d5b2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_d5b3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_d5b4, 1);  ret();                                /* ret */
        }
    }
}
