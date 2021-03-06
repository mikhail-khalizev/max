using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d916-f6bca72c")]
        public void Method_100c_d916()
        {
            ii(0x100c_d916, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_d91b, 5);  call(Definitions.sys_check_available_stack_size, 0x9_8432);/* call 0x10165d52 */
            ii(0x100c_d920, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_d921, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_d922, 1);  push(esi);                            /* push esi */
            ii(0x100c_d923, 1);  push(edi);                            /* push edi */
            ii(0x100c_d924, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_d925, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_d927, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_d92d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_d930, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_d933, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_d93a, 2);  if(jz(0x100c_d950, 0x14)) goto l_0x100c_d950;/* jz 0x100cd950 */
            ii(0x100c_d93c, 5);  mov(edx, 0x101b_5b68);                /* mov edx, 0x101b5b68 */
            ii(0x100c_d941, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d944, 5);  call(Definitions.sys_call_dtor_arr, 0x9_866f);/* call 0x10165fb8 */
            ii(0x100c_d949, 5);  call(Definitions.sys_delete_arr, 0x9_868a);/* call 0x10165fd8 */
            ii(0x100c_d94e, 2);  jmp(0x100c_d97f, 0x2f); goto l_0x100c_d97f;/* jmp 0x100cd97f */
        l_0x100c_d950:
            ii(0x100c_d950, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d953, 7);  mov(memd[ds, eax + 12], 0x101b_5b7c); /* mov dword [eax+0xc], 0x101b5b7c */
            ii(0x100c_d95a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d95d, 4);  cmp(memd[ds, eax + 8], 0);            /* cmp dword [eax+0x8], 0x0 */
            ii(0x100c_d961, 2);  if(jz(0x100c_d96e, 0xb)) goto l_0x100c_d96e;/* jz 0x100cd96e */
            ii(0x100c_d963, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d966, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_d969, 5);  call(Definitions.sys_delete, 0x9_85f6);/* call 0x10165f64 */
        l_0x100c_d96e:
            ii(0x100c_d96e, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_d975, 2);  if(jz(0x100c_d97f, 8)) goto l_0x100c_d97f;/* jz 0x100cd97f */
            ii(0x100c_d977, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d97a, 5);  call(Definitions.sys_delete, 0x9_85e5);/* call 0x10165f64 */
        l_0x100c_d97f:
            ii(0x100c_d97f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d982, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_d985, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_d988, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_d98a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_d98b, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_d98c, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_d98d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_d98e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_d98f, 1);  ret();                                /* ret */
        }
    }
}
