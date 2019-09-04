using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4bdf-f76af7a3")]
        public void Method_100e_4bdf()
        {
            ii(0x100e_4bdf, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_4be4, 5);  call(Definitions.sys_check_available_stack_size, 0x8_1169);/* call 0x10165d52 */
            ii(0x100e_4be9, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_4bea, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_4beb, 1);  push(edx);                            /* push edx */
            ii(0x100e_4bec, 1);  push(esi);                            /* push esi */
            ii(0x100e_4bed, 1);  push(edi);                            /* push edi */
            ii(0x100e_4bee, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_4bef, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_4bf1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_4bf7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_4bfa, 7);  cmp(memd[ds, 0x101b_7f14], 0);        /* cmp dword [0x101b7f14], 0x0 */
            ii(0x100e_4c01, 2);  if(jnz(0x100e_4c0c, 9)) goto l_0x100e_4c0c;/* jnz 0x100e4c0c */
            ii(0x100e_4c03, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100e_4c0a, 2);  jmp(0x100e_4c26, 0x1a); goto l_0x100e_4c26;/* jmp 0x100e4c26 */
        l_0x100e_4c0c:
            ii(0x100e_4c0c, 7);  cmp(memd[ss, ebp - 8], 0x400);        /* cmp dword [ebp-0x8], 0x400 */
            ii(0x100e_4c13, 2);  if(jbe(0x100e_4c1e, 9)) goto l_0x100e_4c1e;/* jbe 0x100e4c1e */
            ii(0x100e_4c15, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100e_4c1c, 2);  jmp(0x100e_4c26, 8); goto l_0x100e_4c26;/* jmp 0x100e4c26 */
        l_0x100e_4c1e:
            ii(0x100e_4c1e, 5);  mov(eax, memd[ds, 0x101b_7f14]);      /* mov eax, [0x101b7f14] */
            ii(0x100e_4c23, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x100e_4c26:
            ii(0x100e_4c26, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_4c29, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_4c2b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_4c2c, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_4c2d, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_4c2e, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_4c2f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_4c30, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_4c31, 1);  ret();                                /* ret */
        }
    }
}
