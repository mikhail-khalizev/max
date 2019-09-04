using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fddd-1fb1d2ac")]
        public void Method_100c_fddd()
        {
            ii(0x100c_fddd, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_fde2, 5); call(Definitions.sys_check_available_stack_size, 0x9_5f6b); /* call 0x10165d52 */
            ii(0x100c_fde7, 1); push(ebx);                              /* push ebx */
            ii(0x100c_fde8, 1); push(ecx);                              /* push ecx */
            ii(0x100c_fde9, 1); push(esi);                              /* push esi */
            ii(0x100c_fdea, 1); push(edi);                              /* push edi */
            ii(0x100c_fdeb, 1); push(ebp);                              /* push ebp */
            ii(0x100c_fdec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fdee, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_fdf4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_fdf7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_fdfa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fdfd, 5); call(Definitions.my_2_get_count, -0x4_4a9a); /* call 0x1008b368 */
            ii(0x100c_fe02, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_fe05, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x100c_fe0c, 2); jmp(0x100c_fe14, 6); goto l_0x100c_fe14; /* jmp 0x100cfe14 */
        l_0x100c_fe0e:
            ii(0x100c_fe0e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_fe11, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x100c_fe14:
            ii(0x100c_fe14, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fe17, 5); call(Definitions.my_2_get_count, -0x4_4ab4); /* call 0x1008b368 */
            ii(0x100c_fe1c, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x100c_fe20, 2); if(jle(0x100c_fe45, 0x23)) goto l_0x100c_fe45; /* jle 0x100cfe45 */
            ii(0x100c_fe22, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100c_fe26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fe29, 5); call(0x1008_b228, -0x4_4c06);           /* call 0x1008b228 */
            ii(0x100c_fe2e, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x100c_fe31, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x100c_fe36, 5); mov(edx, StringDefinitions.Unit2);      /* mov edx, 0x101a1471 */
            ii(0x100c_fe3b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_fe3e, 5); call(0x1014_76e3, 0x7_78a0);            /* call 0x101476e3 */
            ii(0x100c_fe43, 2); jmp(0x100c_fe0e, -0x37); goto l_0x100c_fe0e; /* jmp 0x100cfe0e */
        l_0x100c_fe45:
            ii(0x100c_fe45, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fe47, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_fe48, 1); pop(edi);                               /* pop edi */
            ii(0x100c_fe49, 1); pop(esi);                               /* pop esi */
            ii(0x100c_fe4a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_fe4b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_fe4c, 1); ret();                                  /* ret */
        }
    }
}
