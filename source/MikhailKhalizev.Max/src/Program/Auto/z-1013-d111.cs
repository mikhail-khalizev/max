using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_d111-19daed25")]
        public void Method_1013_d111()
        {
            ii(0x1013_d111, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_d116, 5); call(Definitions.sys_check_available_stack_size, 0x2_8c37); /* call 0x10165d52 */
            ii(0x1013_d11b, 1); push(ebx);                              /* push ebx */
            ii(0x1013_d11c, 1); push(ecx);                              /* push ecx */
            ii(0x1013_d11d, 1); push(edx);                              /* push edx */
            ii(0x1013_d11e, 1); push(esi);                              /* push esi */
            ii(0x1013_d11f, 1); push(edi);                              /* push edi */
            ii(0x1013_d120, 1); push(ebp);                              /* push ebp */
            ii(0x1013_d121, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d123, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1013_d129, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_d12c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_d12f, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1013_d132, 2); if(jz(0x1013_d18c, 0x58)) goto l_0x1013_d18c; /* jz 0x1013d18c */
            ii(0x1013_d134, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_d137, 6); mov(memw[ds, edx + 0xc], 0xffff);       /* mov word [edx+0xc], 0xffff */
            ii(0x1013_d13d, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_d13f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_d142, 3); mov(edx, memd[ds, edx + 0x12]);         /* mov edx, [edx+0x12] */
            ii(0x1013_d145, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1013_d148, 2); mov(ebx, memd[ds, ebx]);                /* mov ebx, [ebx] */
            ii(0x1013_d14a, 4); mov(memw[ds, ebx + 0xf], ax);           /* mov [ebx+0xf], ax */
            ii(0x1013_d14e, 3); mov(memd[ds, ebx + 0xb], edx);          /* mov [ebx+0xb], edx */
            ii(0x1013_d151, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_d154, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1013_d156, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_d159, 5); call(0x1013_ce3f, -0x31f);              /* call 0x1013ce3f */
            ii(0x1013_d15e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_d161, 6); mov(memd[ds, edx], 0);                  /* mov dword [edx], 0x0 */
            ii(0x1013_d167, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_d16a, 4); cmp(memd[ds, edx + 8], 0);              /* cmp dword [edx+0x8], 0x0 */
            ii(0x1013_d16e, 2); if(jz(0x1013_d17b, 0xb)) goto l_0x1013_d17b; /* jz 0x1013d17b */
            ii(0x1013_d170, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_d173, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1013_d176, 5); call(Definitions.sys_fclose, 0x3_4eee); /* call 0x10172069 */
        l_0x1013_d17b:
            ii(0x1013_d17b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_d17e, 7); mov(memd[ds, eax + 8], 0);              /* mov dword [eax+0x8], 0x0 */
            ii(0x1013_d185, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_d188, 4); mov(memb[ds, eax + 0x16], 0);           /* mov byte [eax+0x16], 0x0 */
        l_0x1013_d18c:
            ii(0x1013_d18c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d18e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_d18f, 1); pop(edi);                               /* pop edi */
            ii(0x1013_d190, 1); pop(esi);                               /* pop esi */
            ii(0x1013_d191, 1); pop(edx);                               /* pop edx */
            ii(0x1013_d192, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_d193, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_d194, 1); ret();                                  /* ret */
        }
    }
}
