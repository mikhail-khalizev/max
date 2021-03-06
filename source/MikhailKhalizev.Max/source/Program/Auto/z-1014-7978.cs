using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7978-dca1a012")]
        public void Method_1014_7978()
        {
            ii(0x1014_7978, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_797d, 5);  call(Definitions.sys_check_available_stack_size, 0x1_e3d0);/* call 0x10165d52 */
            ii(0x1014_7982, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7983, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7984, 1);  push(esi);                            /* push esi */
            ii(0x1014_7985, 1);  push(edi);                            /* push edi */
            ii(0x1014_7986, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7987, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7989, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_798f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7992, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_7995, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_799c, 2);  if(jz(0x1014_79b2, 0x14)) goto l_0x1014_79b2;/* jz 0x101479b2 */
            ii(0x1014_799e, 5);  mov(edx, 0x101b_7130);                /* mov edx, 0x101b7130 */
            ii(0x1014_79a3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_79a6, 5);  call(Definitions.sys_call_dtor_arr, 0x1_e60d);/* call 0x10165fb8 */
            ii(0x1014_79ab, 5);  call(Definitions.sys_delete_arr, 0x1_e628);/* call 0x10165fd8 */
            ii(0x1014_79b0, 2);  jmp(0x1014_79d3, 0x21); goto l_0x1014_79d3;/* jmp 0x101479d3 */
        l_0x1014_79b2:
            ii(0x1014_79b2, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1014_79b7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_79ba, 5);  call(0x1014_4fba, -0x2a05);           /* call 0x10144fba */
            ii(0x1014_79bf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_79c2, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_79c9, 2);  if(jz(0x1014_79d3, 8)) goto l_0x1014_79d3;/* jz 0x101479d3 */
            ii(0x1014_79cb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_79ce, 5);  call(Definitions.sys_delete, 0x1_e591);/* call 0x10165f64 */
        l_0x1014_79d3:
            ii(0x1014_79d3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_79d6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_79d9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_79dc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_79de, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_79df, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_79e0, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_79e1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_79e2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_79e3, 1);  ret();                                /* ret */
        }
    }
}
