using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d0e0de03-6606-4dfa-b40f-09aa1ea965a4")]
        public void Method_1011_fd0c()
        {
            ii(0x1011_fd0c, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1011_fd11, 5); calld(Definitions.sys_check_available_stack_size, 0x4_603c); /* call 0x10165d52 */
            ii(0x1011_fd16, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_fd17, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_fd18, 1); pushd(esi);                             /* push esi */
            ii(0x1011_fd19, 1); pushd(edi);                             /* push edi */
            ii(0x1011_fd1a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_fd1b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fd1d, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1011_fd23, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_fd26, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_fd29, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_fd2c, 3); mov(ebx, memd_a32[ds, eax + 0x41]);     /* mov ebx, [eax+0x41] */
            ii(0x1011_fd2f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_fd32, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_fd35, 3); mov(edx, memd_a32[ds, eax + 0x3f]);     /* mov edx, [eax+0x3f] */
            ii(0x1011_fd38, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_fd3b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1011_fd3e, 5); calld(0x1007_6aac, -0xa_9297);          /* call 0x10076aac */
            ii(0x1011_fd43, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1011_fd47, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1011_fd4a, 5); calld(0x100b_7fdc, -0x6_7d73);          /* call 0x100b7fdc */
            ii(0x1011_fd4f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_fd52, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1011_fd56, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1011_fd5b, 5); calld(Definitions.sys_new, 0x4_60a0);   /* call 0x10165e00 */
            ii(0x1011_fd60, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_fd63, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_fd66, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_fd69, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1011_fd6d, 2); if(jzd(0x1011_fd96, 0x27)) goto l_0x1011_fd96; /* jz 0x1011fd96 */
            ii(0x1011_fd6f, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1011_fd72, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_fd75, 5); calld(0x1007_5e64, -0xa_9f16);          /* call 0x10075e64 */
            ii(0x1011_fd7a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_fd7c, 4); movsx(ebx, memb_a32[ss, ebp - 0x4]);    /* movsx ebx, byte [ebp-0x4] */
            ii(0x1011_fd80, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_fd83, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_fd86, 5); calld(0x1011_d0ea, -0x2ca1);            /* call 0x1011d0ea */
            ii(0x1011_fd8b, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_fd8e, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_fd91, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_fd94, 2); jmpd(0x1011_fd9c, 0x6); goto l_0x1011_fd9c; /* jmp 0x1011fd9c */
        l_0x1011_fd96:
            ii(0x1011_fd96, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_fd99, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x1011_fd9c:
            ii(0x1011_fd9c, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1011_fd9f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1011_fda2, 5); calld(0x100b_7fa4, -0x6_7e03);          /* call 0x100b7fa4 */
            ii(0x1011_fda7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1011_fdaa, 5); calld(0x100b_7f74, -0x6_7e3b);          /* call 0x100b7f74 */
            ii(0x1011_fdaf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_fdb1, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fdb6, 5); calld(0x1011_dd56, -0x2065);            /* call 0x1011dd56 */
            ii(0x1011_fdbb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fdbd, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1011_fdc0, 5); calld(0x100b_7368, -0x6_8a5d);          /* call 0x100b7368 */
            ii(0x1011_fdc5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fdc7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_fdc8, 1); popd(edi);                              /* pop edi */
            ii(0x1011_fdc9, 1); popd(esi);                              /* pop esi */
            ii(0x1011_fdca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_fdcb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_fdcc, 1); retd(); return;                         /* ret */
        }
    }
}