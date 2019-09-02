using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_fabe-565d3992")]
        public void Method_1014_fabe()
        {
            ii(0x1014_fabe, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_fac3, 5); call(Definitions.sys_check_available_stack_size, 0x1_628a); /* call 0x10165d52 */
            ii(0x1014_fac8, 1); push(ebx);                              /* push ebx */
            ii(0x1014_fac9, 1); push(ecx);                              /* push ecx */
            ii(0x1014_faca, 1); push(esi);                              /* push esi */
            ii(0x1014_facb, 1); push(edi);                              /* push edi */
            ii(0x1014_facc, 1); push(ebp);                              /* push ebp */
            ii(0x1014_facd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_facf, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1014_fad5, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_fad8, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_fadb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_fade, 7); cmp(memd[ds, eax + 167], 0);            /* cmp dword [eax+0xa7], 0x0 */
            ii(0x1014_fae5, 2); if(jz(0x1014_faf5, 0xe)) goto l_0x1014_faf5; /* jz 0x1014faf5 */
            ii(0x1014_fae7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_faea, 6); mov(eax, memd[ds, eax + 167]);          /* mov eax, [eax+0xa7] */
            ii(0x1014_faf0, 5); call(Definitions.sys_delete, 0x1_646f); /* call 0x10165f64 */
        l_0x1014_faf5:
            ii(0x1014_faf5, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_faf9, 2); if(jz(0x1014_fb07, 0xc)) goto l_0x1014_fb07; /* jz 0x1014fb07 */
            ii(0x1014_fafb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_fafe, 5); call(Definitions.sys_strlen, 0x2_23c4); /* call 0x10171ec7 */
            ii(0x1014_fb03, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_fb05, 2); if(jnz(0x1014_fb16, 0xf)) goto l_0x1014_fb16; /* jnz 0x1014fb16 */
        l_0x1014_fb07:
            ii(0x1014_fb07, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_fb0a, 10); mov(memd[ds, eax + 167], 0);           /* mov dword [eax+0xa7], 0x0 */
            ii(0x1014_fb14, 2); jmp(0x1014_fb40, 0x2a); goto l_0x1014_fb40; /* jmp 0x1014fb40 */
        l_0x1014_fb16:
            ii(0x1014_fb16, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_fb19, 5); call(Definitions.sys_strlen, 0x2_23a9); /* call 0x10171ec7 */
            ii(0x1014_fb1e, 1); inc(eax);                               /* inc eax */
            ii(0x1014_fb1f, 5); call(Definitions.sys_new_arr, 0x1_64ec); /* call 0x10166010 */
            ii(0x1014_fb24, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_fb26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_fb29, 6); mov(memd[ds, eax + 167], edx);          /* mov [eax+0xa7], edx */
            ii(0x1014_fb2f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_fb32, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_fb35, 6); mov(eax, memd[ds, eax + 167]);          /* mov eax, [eax+0xa7] */
            ii(0x1014_fb3b, 5); call(Definitions.sys_strcpy, 0x1_638f); /* call 0x10165ecf */
        l_0x1014_fb40:
            ii(0x1014_fb40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_fb42, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_fb43, 1); pop(edi);                               /* pop edi */
            ii(0x1014_fb44, 1); pop(esi);                               /* pop esi */
            ii(0x1014_fb45, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_fb46, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_fb47, 1); ret();                                  /* ret */
        }
    }
}
