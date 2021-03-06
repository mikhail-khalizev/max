using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_69d8-d9903dac")]
        public void Method_1007_69d8()
        {
            ii(0x1007_69d8, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_69dd, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f370);/* call 0x10165d52 */
            ii(0x1007_69e2, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_69e3, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_69e4, 1);  push(edx);                            /* push edx */
            ii(0x1007_69e5, 1);  push(esi);                            /* push esi */
            ii(0x1007_69e6, 1);  push(edi);                            /* push edi */
            ii(0x1007_69e7, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_69e8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_69ea, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_69f0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_69f3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_69f6, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1007_69f9, 2);  if(jz(0x1007_6a04, 9)) goto l_0x1007_6a04;/* jz 0x10076a04 */
            ii(0x1007_69fb, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_6a02, 2);  jmp(0x1007_6a1d, 0x19); goto l_0x1007_6a1d;/* jmp 0x10076a1d */
        l_0x1007_6a04:
            ii(0x1007_6a04, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x1007_6a09, 5);  mov(ebx, StringDefinitions.SmartptrH7);/* mov ebx, 0x101a0004 */
            ii(0x1007_6a0e, 5);  mov(edx, StringDefinitions.PtrNotEqual07);/* mov edx, 0x101a000f */
            ii(0x1007_6a13, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_6a15, 5);  call(Definitions.sys_assert, 0xe_f378);/* call 0x10165d92 */
            ii(0x1007_6a1a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1007_6a1d:
            ii(0x1007_6a1d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6a20, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_6a22, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_6a25, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_6a28, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6a2a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6a2b, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6a2c, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6a2d, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6a2e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6a2f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6a30, 1);  ret();                                /* ret */
        }
    }
}
