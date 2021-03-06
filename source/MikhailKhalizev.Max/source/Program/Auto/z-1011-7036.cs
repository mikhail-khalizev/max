using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7036-819b541")]
        public void Method_1011_7036()
        {
            ii(0x1011_7036, 5);  push(0x68);                           /* push 0x68 */
            ii(0x1011_703b, 5);  call(Definitions.sys_check_available_stack_size, 0x4_ed12);/* call 0x10165d52 */
            ii(0x1011_7040, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_7041, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_7042, 1);  push(esi);                            /* push esi */
            ii(0x1011_7043, 1);  push(edi);                            /* push edi */
            ii(0x1011_7044, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_7045, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_7047, 6);  sub(esp, 0x50);                       /* sub esp, 0x50 */
            ii(0x1011_704d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7050, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1011_7053, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1011_7057, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_7059, 3);  mov(bl, memb[ss, ebp - 4]);           /* mov bl, [ebp-0x4] */
            ii(0x1011_705c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_705f, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1011_7062, 5);  call(0x1011_6bee, -0x479);            /* call 0x10116bee */
            ii(0x1011_7067, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1011_706a, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1011_706e, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1011_7071, 5);  call(0x1011_6f53, -0x123);            /* call 0x10116f53 */
            ii(0x1011_7076, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1011_7079, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_707b, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1011_707e, 5);  call(0x1011_6e81, -0x202);            /* call 0x10116e81 */
            ii(0x1011_7083, 2);  jmp(0x1011_708f, 0xa); goto l_0x1011_708f;/* jmp 0x1011708f */
        //  ii(0x1011_7085, 10);  Недостижимый код.
        l_0x1011_708f:
            ii(0x1011_708f, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1011_7092, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_7094, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7095, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7096, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_7097, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_7098, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_7099, 1);  ret();                                /* ret */
        }
    }
}
