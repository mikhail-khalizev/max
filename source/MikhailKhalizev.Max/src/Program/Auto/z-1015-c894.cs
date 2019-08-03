using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("08736cc1-b21d-4b4b-a4cb-7521d1ac16fd")]
        public void Method_1015_c894()
        {
            ii(0x1015_c894, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_c899, 5); calld(Definitions.sys_check_available_stack_size, 0x94b4); /* call 0x10165d52 */
            ii(0x1015_c89e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_c89f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_c8a0, 1); pushd(edx);                             /* push edx */
            ii(0x1015_c8a1, 1); pushd(esi);                             /* push esi */
            ii(0x1015_c8a2, 1); pushd(edi);                             /* push edi */
            ii(0x1015_c8a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_c8a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_c8a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_c8ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_c8af, 4); mov(memb_a32[ss, ebp - 0x8], 0x4);      /* mov byte [ebp-0x8], 0x4 */
        l_0x1015_c8b3:
            ii(0x1015_c8b3, 3); dec(memb_a32[ss, ebp - 0x8]);           /* dec byte [ebp-0x8] */
            ii(0x1015_c8b6, 4); cmp(memb_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp byte [ebp-0x8], 0xff */
            ii(0x1015_c8ba, 2); if(jzd(0x1015_c8e7, 0x2b)) goto l_0x1015_c8e7; /* jz 0x1015c8e7 */
            ii(0x1015_c8bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c8bf, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_c8c2, 3); cmp(al, memb_a32[ss, ebp - 0x8]);       /* cmp al, [ebp-0x8] */
            ii(0x1015_c8c5, 2); if(jzd(0x1015_c8db, 0x14)) goto l_0x1015_c8db; /* jz 0x1015c8db */
            ii(0x1015_c8c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_c8c9, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_c8cc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c8cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c8d2, 5); calld(0x1007_6074, -0xe6863);           /* call 0x10076074 */
            ii(0x1015_c8d7, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c8d9, 2); if(jnzd(0x1015_c8dd, 0x2)) goto l_0x1015_c8dd; /* jnz 0x1015c8dd */
        l_0x1015_c8db:
            ii(0x1015_c8db, 2); jmpd(0x1015_c8e5, 0x8); goto l_0x1015_c8e5; /* jmp 0x1015c8e5 */
        l_0x1015_c8dd:
            ii(0x1015_c8dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c8e0, 5); calld(0x1015_c858, -0x8d);              /* call 0x1015c858 */
        l_0x1015_c8e5:
            ii(0x1015_c8e5, 2); jmpd(0x1015_c8b3, -0x34); goto l_0x1015_c8b3; /* jmp 0x1015c8b3 */
        l_0x1015_c8e7:
            ii(0x1015_c8e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_c8e9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_c8ea, 1); popd(edi);                              /* pop edi */
            ii(0x1015_c8eb, 1); popd(esi);                              /* pop esi */
            ii(0x1015_c8ec, 1); popd(edx);                              /* pop edx */
            ii(0x1015_c8ed, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_c8ee, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_c8ef, 1); retd(); return;                         /* ret */
        }
    }
}
