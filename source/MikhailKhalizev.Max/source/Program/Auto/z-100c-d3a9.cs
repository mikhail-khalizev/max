using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d3a9-dac79983")]
        public void Method_100c_d3a9()
        {
            ii(0x100c_d3a9, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_d3ae, 5);  call(Definitions.sys_check_available_stack_size, 0x9_899f);/* call 0x10165d52 */
            ii(0x100c_d3b3, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_d3b4, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_d3b5, 1);  push(esi);                            /* push esi */
            ii(0x100c_d3b6, 1);  push(edi);                            /* push edi */
            ii(0x100c_d3b7, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_d3b8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_d3ba, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_d3c0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_d3c3, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_d3c6, 5);  mov(edx, StringDefinitions.UpgradUnit);/* mov edx, 0x101a145e */
            ii(0x100c_d3cb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d3ce, 5);  call(Definitions.sys_strcpy, 0x9_8afc);/* call 0x10165ecf */
            ii(0x100c_d3d3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d3d6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_d3d9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_d3dc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_d3de, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_d3df, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_d3e0, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_d3e1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_d3e2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_d3e3, 1);  ret();                                /* ret */
        }
    }
}
