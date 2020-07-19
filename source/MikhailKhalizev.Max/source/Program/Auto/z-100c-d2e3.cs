using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d2e3-1a608cf8")]
        public void Method_100c_d2e3()
        {
            ii(0x100c_d2e3, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_d2e8, 5);  call(Definitions.sys_check_available_stack_size, 0x9_8a65);/* call 0x10165d52 */
            ii(0x100c_d2ed, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_d2ee, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_d2ef, 1);  push(edx);                            /* push edx */
            ii(0x100c_d2f0, 1);  push(esi);                            /* push esi */
            ii(0x100c_d2f1, 1);  push(edi);                            /* push edi */
            ii(0x100c_d2f2, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_d2f3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_d2f5, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_d2fb, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_d2fe, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d301, 5);  call(0x100c_bb8b, -0x177b);           /* call 0x100cbb8b */
            ii(0x100c_d306, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_d309, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x100c_d30e, 2);  if(jz(0x100c_d31c, 0xc)) goto l_0x100c_d31c;/* jz 0x100cd31c */
            ii(0x100c_d310, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_d314, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d317, 5);  call(0x100c_bc91, -0x168b);           /* call 0x100cbc91 */
        l_0x100c_d31c:
            ii(0x100c_d31c, 5);  cmp(memw[ss, ebp - 8], 0xb);          /* cmp word [ebp-0x8], 0xb */
            ii(0x100c_d321, 2);  if(jnz(0x100c_d330, 0xd)) goto l_0x100c_d330;/* jnz 0x100cd330 */
            ii(0x100c_d323, 5);  mov(edx, 0x4b);                       /* mov edx, 0x4b */
            ii(0x100c_d328, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d32b, 5);  call(0x100c_bc91, -0x169f);           /* call 0x100cbc91 */
        l_0x100c_d330:
            ii(0x100c_d330, 5);  cmp(memw[ss, ebp - 8], 9);            /* cmp word [ebp-0x8], 0x9 */
            ii(0x100c_d335, 2);  if(jz(0x100c_d33e, 7)) goto l_0x100c_d33e;/* jz 0x100cd33e */
            ii(0x100c_d337, 5);  cmp(memw[ss, ebp - 8], 3);            /* cmp word [ebp-0x8], 0x3 */
            ii(0x100c_d33c, 2);  if(jnz(0x100c_d340, 2)) goto l_0x100c_d340;/* jnz 0x100cd340 */
        l_0x100c_d33e:
            ii(0x100c_d33e, 2);  jmp(0x100c_d347, 7); goto l_0x100c_d347;/* jmp 0x100cd347 */
        l_0x100c_d340:
            ii(0x100c_d340, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x100c_d345, 2);  if(jnz(0x100c_d354, 0xd)) goto l_0x100c_d354;/* jnz 0x100cd354 */
        l_0x100c_d347:
            ii(0x100c_d347, 5);  mov(edx, 0x3b);                       /* mov edx, 0x3b */
            ii(0x100c_d34c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d34f, 5);  call(0x100c_bc91, -0x16c3);           /* call 0x100cbc91 */
        l_0x100c_d354:
            ii(0x100c_d354, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_d356, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_d357, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_d358, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_d359, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_d35a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_d35b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_d35c, 1);  ret();                                /* ret */
        }
    }
}
