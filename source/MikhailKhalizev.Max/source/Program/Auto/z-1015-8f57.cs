using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8f57-b4c1c666")]
        public void Method_1015_8f57()
        {
            ii(0x1015_8f57, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1015_8f5c, 5);  call(Definitions.sys_check_available_stack_size, 0xcdf1);/* call 0x10165d52 */
            ii(0x1015_8f61, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_8f62, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_8f63, 1);  push(esi);                            /* push esi */
            ii(0x1015_8f64, 1);  push(edi);                            /* push edi */
            ii(0x1015_8f65, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_8f66, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_8f68, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1015_8f6e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_8f71, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_8f74, 5);  mov(eax, 0x1015_8f09);                /* mov eax, 0x10158f09 */
            ii(0x1015_8f79, 1);  push(eax);                            /* push eax */
            ii(0x1015_8f7a, 7);  mov(memd[ss, ebp - 20], 0x31);        /* mov dword [ebp-0x14], 0x31 */
            ii(0x1015_8f81, 5);  mov(eax, StringDefinitions.Reload2);  /* mov eax, 0x101b250b */
            ii(0x1015_8f86, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_8f89, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_8f8c, 4);  cmp(memb[ds, eax + 87], 6);           /* cmp byte [eax+0x57], 0x6 */
            ii(0x1015_8f90, 2);  if(jnz(0x1015_8f98, 6)) goto l_0x1015_8f98;/* jnz 0x10158f98 */
            ii(0x1015_8f92, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_8f96, 2);  jmp(0x1015_8f9c, 4); goto l_0x1015_8f9c;/* jmp 0x10158f9c */
        l_0x1015_8f98:
            ii(0x1015_8f98, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_8f9c:
            ii(0x1015_8f9c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_8f9e, 3);  mov(dl, memb[ss, ebp - 12]);          /* mov dl, [ebp-0xc] */
            ii(0x1015_8fa1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_8fa4, 3);  mov(ecx, memd[ss, ebp - 20]);         /* mov ecx, [ebp-0x14] */
            ii(0x1015_8fa7, 3);  mov(ebx, memd[ss, ebp - 16]);         /* mov ebx, [ebp-0x10] */
            ii(0x1015_8faa, 5);  call(0x1015_7ccf, -0x12e0);           /* call 0x10157ccf */
            ii(0x1015_8faf, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_8fb2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_8fb5, 5);  call(0x1015_8bbb, -0x3ff);            /* call 0x10158bbb */
            ii(0x1015_8fba, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_8fbc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_8fbd, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_8fbe, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_8fbf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_8fc0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_8fc1, 1);  ret();                                /* ret */
        }
    }
}
