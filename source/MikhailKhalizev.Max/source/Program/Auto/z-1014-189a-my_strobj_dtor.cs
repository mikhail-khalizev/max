using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_189a-be0c9c07")]
        public void my_strobj_dtor()
        {
            ii(0x1014_189a, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_189f, 5);  call(Definitions.sys_check_available_stack_size, 0x2_44ae);/* call 0x10165d52 */
            ii(0x1014_18a4, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_18a5, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_18a6, 1);  push(esi);                            /* push esi */
            ii(0x1014_18a7, 1);  push(edi);                            /* push edi */
            ii(0x1014_18a8, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_18a9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_18ab, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_18b1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_18b4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_18b7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_18ba, 4);  cmp(memd[ds, eax + 8], 0);            /* cmp dword [eax+0x8], 0x0 */
            ii(0x1014_18be, 2);  if(jnz(0x1014_18c9, 9)) goto l_0x1014_18c9;/* jnz 0x101418c9 */
            ii(0x1014_18c0, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_18c7, 2);  jmp(0x1014_18e2, 0x19); goto l_0x1014_18e2;/* jmp 0x101418e2 */
        l_0x1014_18c9:
            ii(0x1014_18c9, 5);  mov(ecx, 0x3f);                       /* mov ecx, 0x3f */
            ii(0x1014_18ce, 5);  mov(ebx, StringDefinitions.StrobjCpp);/* mov ebx, 0x101ace94 */
            ii(0x1014_18d3, 5);  mov(edx, StringDefinitions.RefCountEqual0);/* mov edx, 0x101ace9f */
            ii(0x1014_18d8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1014_18da, 5);  call(Definitions.sys_assert, 0x2_44b3);/* call 0x10165d92 */
            ii(0x1014_18df, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1014_18e2:
            ii(0x1014_18e2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_18e5, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_18e7, 5);  call(Definitions.sys_delete_arr, 0x2_46ec);/* call 0x10165fd8 */
            ii(0x1014_18ec, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_18ef, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_18f2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_18f5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_18f7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_18f8, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_18f9, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_18fa, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_18fb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_18fc, 1);  ret();                                /* ret */
        }
    }
}
