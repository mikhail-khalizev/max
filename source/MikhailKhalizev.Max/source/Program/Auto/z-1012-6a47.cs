using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_6a47-25e8cc1")]
        public void Method_1012_6a47()
        {
            ii(0x1012_6a47, 5);  push(0x90);                           /* push 0x90 */
            ii(0x1012_6a4c, 5);  call(Definitions.sys_check_available_stack_size, 0x3_f301);/* call 0x10165d52 */
            ii(0x1012_6a51, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_6a52, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_6a53, 1);  push(edx);                            /* push edx */
            ii(0x1012_6a54, 1);  push(esi);                            /* push esi */
            ii(0x1012_6a55, 1);  push(edi);                            /* push edi */
            ii(0x1012_6a56, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_6a57, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_6a59, 6);  sub(esp, 0x68);                       /* sub esp, 0x68 */
            ii(0x1012_6a5f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_6a62, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6a66, 1);  push(eax);                            /* push eax */
            ii(0x1012_6a67, 5);  mov(eax, StringDefinitions.UnknownUnitIdIReferencedInRemotePacket);/* mov eax, 0x101a81d2 */
            ii(0x1012_6a6c, 1);  push(eax);                            /* push eax */
            ii(0x1012_6a6d, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x1012_6a70, 1);  push(eax);                            /* push eax */
            ii(0x1012_6a71, 5);  call(Definitions.sys_sprintf, 0x3_f48b);/* call 0x10165f01 */
            ii(0x1012_6a76, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1012_6a79, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1012_6a7e, 1);  push(eax);                            /* push eax */
            ii(0x1012_6a7f, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1012_6a81, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1012_6a86, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x1012_6a8b, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x1012_6a8e, 5);  call(0x1011_5d23, -0x1_0d70);         /* call 0x10115d23 */
            ii(0x1012_6a93, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_6a95, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_6a96, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_6a97, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_6a98, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_6a99, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_6a9a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_6a9b, 1);  ret();                                /* ret */
        }
    }
}
