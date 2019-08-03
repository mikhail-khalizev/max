using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("06311464-54fe-4e08-96fa-ffbbb37f0b76")]
        public void Method_100d_c405()
        {
            ii(0x100d_c405, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100d_c40a, 5); calld(Definitions.sys_check_available_stack_size, 0x89943); /* call 0x10165d52 */
            ii(0x100d_c40f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_c410, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_c411, 1); pushd(esi);                             /* push esi */
            ii(0x100d_c412, 1); pushd(edi);                             /* push edi */
            ii(0x100d_c413, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_c414, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_c416, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_c41c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_c41f, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100d_c422, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_c425, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x100d_c427, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x100d_c42a, 5); calld(0x1007_5fdc, -0x66453);           /* call 0x10075fdc */
            ii(0x100d_c42f, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100d_c432, 6); if(jnzd(0x100d_c4f3, 0xbb)) goto l_0x100d_c4f3; /* jnz 0x100dc4f3 */
            ii(0x100d_c438, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x100d_c43d, 5); calld(0x1007_5fdc, -0x66466);           /* call 0x10075fdc */
            ii(0x100d_c442, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_c444, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100d_c449, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_c44b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_c44e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_c450, 3); lea(edx, eax + 0x12);                   /* lea edx, [eax+0x12] */
            ii(0x100d_c453, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100d_c458, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_c45a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_c45d, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_c45f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_c462, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100d_c467, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c46b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_c471, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100d_c476, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_c478, 5); calld(0x100d_fd2c, 0x38af);             /* call 0x100dfd2c */
            ii(0x100d_c47d, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100d_c481, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_c484, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100d_c489, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c48d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_c493, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100d_c498, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_c49a, 5); calld(0x100d_fd2c, 0x388d);             /* call 0x100dfd2c */
            ii(0x100d_c49f, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100d_c4a3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100d_c4a6:
            ii(0x100d_c4a6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_c4a9, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_c4ad, 2); if(jld(0x100d_c4f3, 0x44)) goto l_0x100d_c4f3; /* jl 0x100dc4f3 */
            ii(0x100d_c4af, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_c4b2, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_c4b6, 2); if(jld(0x100d_c4d0, 0x18)) goto l_0x100d_c4d0; /* jl 0x100dc4d0 */
            ii(0x100d_c4b8, 7); mov(memd_a32[ss, ebp - 0x18], 0x3d);    /* mov dword [ebp-0x18], 0x3d */
            ii(0x100d_c4bf, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100d_c4c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c4c5, 5); calld(0x1008_b2a8, -0x51222);           /* call 0x1008b2a8 */
            ii(0x100d_c4ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_c4cd, 3); sub(memd_a32[ss, ebp - 0x14], eax);     /* sub [ebp-0x14], eax */
        l_0x100d_c4d0:
            ii(0x100d_c4d0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_c4d3, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100d_c4d7, 2); if(jld(0x100d_c4f1, 0x18)) goto l_0x100d_c4f1; /* jl 0x100dc4f1 */
            ii(0x100d_c4d9, 7); mov(memd_a32[ss, ebp - 0x1c], 0x31);    /* mov dword [ebp-0x1c], 0x31 */
            ii(0x100d_c4e0, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100d_c4e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c4e6, 5); calld(0x1008_b2a8, -0x51243);           /* call 0x1008b2a8 */
            ii(0x100d_c4eb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_c4ee, 3); sub(memd_a32[ss, ebp - 0x14], eax);     /* sub [ebp-0x14], eax */
        l_0x100d_c4f1:
            ii(0x100d_c4f1, 2); jmpd(0x100d_c4a6, -0x4d); goto l_0x100d_c4a6; /* jmp 0x100dc4a6 */
        l_0x100d_c4f3:
            ii(0x100d_c4f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_c4f5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_c4f6, 1); popd(edi);                              /* pop edi */
            ii(0x100d_c4f7, 1); popd(esi);                              /* pop esi */
            ii(0x100d_c4f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_c4f9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_c4fa, 1); retd(); return;                         /* ret */
        }
    }
}