using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f9cf-b3d83e26")]
        public void Method_1014_f9cf()
        {
            ii(0x1014_f9cf, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1014_f9d4, 5);  call(Definitions.sys_check_available_stack_size, 0x1_6379);/* call 0x10165d52 */
            ii(0x1014_f9d9, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_f9da, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_f9db, 1);  push(esi);                            /* push esi */
            ii(0x1014_f9dc, 1);  push(edi);                            /* push edi */
            ii(0x1014_f9dd, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_f9de, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_f9e0, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_f9e6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_f9e9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_f9ec, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f9ef, 7);  cmp(memd[ds, eax + 167], 0);          /* cmp dword [eax+0xa7], 0x0 */
            ii(0x1014_f9f6, 2);  if(jnz(0x1014_fa2a, 0x32)) goto l_0x1014_fa2a;/* jnz 0x1014fa2a */
            ii(0x1014_f9f8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f9fb, 3);  mov(al, memb[ds, eax + 39]);          /* mov al, [eax+0x27] */
            ii(0x1014_f9fe, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_fa03, 1);  push(eax);                            /* push eax */
            ii(0x1014_fa04, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fa07, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_fa0a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_fa0d, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1014_fa10, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x1014_fa16, 5);  mov(eax, StringDefinitions.SI);       /* mov eax, 0x101adddd */
            ii(0x1014_fa1b, 1);  push(eax);                            /* push eax */
            ii(0x1014_fa1c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fa1f, 1);  push(eax);                            /* push eax */
            ii(0x1014_fa20, 5);  call(Definitions.sys_sprintf, 0x1_64dc);/* call 0x10165f01 */
            ii(0x1014_fa25, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1014_fa28, 2);  jmp(0x1014_fa3b, 0x11); goto l_0x1014_fa3b;/* jmp 0x1014fa3b */
        l_0x1014_fa2a:
            ii(0x1014_fa2a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fa2d, 6);  mov(edx, memd[ds, eax + 167]);        /* mov edx, [eax+0xa7] */
            ii(0x1014_fa33, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fa36, 5);  call(Definitions.sys_strcpy, 0x1_6494);/* call 0x10165ecf */
        l_0x1014_fa3b:
            ii(0x1014_fa3b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_fa3d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_fa3e, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_fa3f, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_fa40, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_fa41, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_fa42, 1);  ret();                                /* ret */
        }
    }
}
