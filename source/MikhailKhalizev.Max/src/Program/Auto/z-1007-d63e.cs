using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("785ebf5c-10e3-4824-a093-b9fc20d5c012")]
        public void Method_1007_d63e()
        {
            ii(0x1007_d63e, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_d643, 5); calld(Definitions.sys_check_available_stack_size, 0xe_870a); /* call 0x10165d52 */
            ii(0x1007_d648, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_d649, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_d64a, 1); pushd(esi);                             /* push esi */
            ii(0x1007_d64b, 1); pushd(edi);                             /* push edi */
            ii(0x1007_d64c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_d64d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d64f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_d655, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_d658, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_d65b, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_d662, 2); jmpd(0x1007_d66a, 0x6); goto l_0x1007_d66a; /* jmp 0x1007d66a */
        l_0x1007_d664:
            ii(0x1007_d664, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_d667, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1007_d66a:
            ii(0x1007_d66a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d66d, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1007_d670, 5); calld(Definitions.my_2_get_count, 0xdcf3); /* call 0x1008b368 */
            ii(0x1007_d675, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1007_d679, 2); if(jled(0x1007_d6b3, 0x38)) goto l_0x1007_d6b3; /* jle 0x1007d6b3 */
            ii(0x1007_d67b, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_d67f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d682, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1007_d685, 5); calld(0x1008_b228, 0xdb9e);             /* call 0x1008b228 */
            ii(0x1007_d68a, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_d68d, 5); calld(0x100c_defa, 0x5_0868);           /* call 0x100cdefa */
            ii(0x1007_d692, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_d695, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_d699, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_d69b, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1007_d69e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_d6a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_d6a3, 2); if(jled(0x1007_d6b1, 0xc)) goto l_0x1007_d6b1; /* jle 0x1007d6b1 */
            ii(0x1007_d6a5, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_d6a9, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_d6ab, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1007_d6ae, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
        l_0x1007_d6b1:
            ii(0x1007_d6b1, 2); jmpd(0x1007_d664, -0x4f); goto l_0x1007_d664; /* jmp 0x1007d664 */
        l_0x1007_d6b3:
            ii(0x1007_d6b3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d6b5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_d6b6, 1); popd(edi);                              /* pop edi */
            ii(0x1007_d6b7, 1); popd(esi);                              /* pop esi */
            ii(0x1007_d6b8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_d6b9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_d6ba, 1); retd(); return;                         /* ret */
        }
    }
}
