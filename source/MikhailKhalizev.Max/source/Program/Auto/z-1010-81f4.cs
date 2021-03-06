using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_81f4-c0b930d4")]
        public void Method_1010_81f4()
        {
            ii(0x1010_81f4, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_81f9, 5);  call(Definitions.sys_check_available_stack_size, 0x5_db54);/* call 0x10165d52 */
            ii(0x1010_81fe, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_81ff, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_8200, 1);  push(edx);                            /* push edx */
            ii(0x1010_8201, 1);  push(esi);                            /* push esi */
            ii(0x1010_8202, 1);  push(edi);                            /* push edi */
            ii(0x1010_8203, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_8204, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_8206, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_820c, 7);  cmp(memb[ds, 0x101c_4dd6], 0);        /* cmp byte [0x101c4dd6], 0x0 */
            ii(0x1010_8213, 2);  if(jz(0x1010_821e, 9)) goto l_0x1010_821e;/* jz 0x1010821e */
            ii(0x1010_8215, 7);  mov(memd[ss, ebp - 4], 0xffff_ffff);  /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x1010_821c, 2);  jmp(0x1010_8262, 0x44); goto l_0x1010_8262;/* jmp 0x10108262 */
        l_0x1010_821e:
            ii(0x1010_821e, 5);  mov(eax, 0x24);                       /* mov eax, 0x24 */
            ii(0x1010_8223, 5);  call(/* sys */ 0x1017_92be, 0x7_1096);/* call 0x101792be */
            ii(0x1010_8228, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1010_822a, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1010_822c, 7);  mov(memw[ds, 0x101c_4dd4], bx);       /* mov [0x101c4dd4], bx */
            ii(0x1010_8233, 6);  mov(memd[ds, 0x101c_4dd0], ecx);      /* mov [0x101c4dd0], ecx */
            ii(0x1010_8239, 2);  mov(eax, cs);                         /* mov eax, cs */
            ii(0x1010_823b, 5);  mov(ecx, 0x100e_fbba);                /* mov ecx, 0x100efbba */
            ii(0x1010_8240, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1010_8242, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1010_8244, 5);  mov(edx, 0x24);                       /* mov edx, 0x24 */
            ii(0x1010_8249, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1010_824b, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1010_824d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1010_824f, 5);  call(/* sys */ 0x1017_92f0, 0x7_109c);/* call 0x101792f0 */
            ii(0x1010_8254, 7);  mov(memb[ds, 0x101c_4dd6], 1);        /* mov byte [0x101c4dd6], 0x1 */
            ii(0x1010_825b, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1010_8262:
            ii(0x1010_8262, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8265, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_8267, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_8268, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_8269, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_826a, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_826b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_826c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_826d, 1);  ret();                                /* ret */
        }
    }
}
