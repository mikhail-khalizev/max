using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e021ad05-80cb-4bc9-8ebd-7e29eb02a336")]
        public void Method_1015_2aa9()
        {
            ii(0x1015_2aa9, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_2aae, 5); calld(Definitions.sys_check_available_stack_size, 0x1_329f); /* call 0x10165d52 */
            ii(0x1015_2ab3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_2ab4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_2ab5, 1); pushd(edx);                             /* push edx */
            ii(0x1015_2ab6, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2ab7, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2ab8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2ab9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2abb, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_2ac1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_2ac4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2ac7, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2aca, 5); calld(0x1007_6730, -0xd_c39f);          /* call 0x10076730 */
            ii(0x1015_2acf, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1015_2ad2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2ad5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_2ad7, 2); if(jnzd(0x1015_2ae5, 0xc)) goto l_0x1015_2ae5; /* jnz 0x10152ae5 */
            ii(0x1015_2ad9, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1015_2ae0, 5); jmpd(0x1015_2b80, 0x9b); goto l_0x1015_2b80; /* jmp 0x10152b80 */
        l_0x1015_2ae5:
            ii(0x1015_2ae5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2ae8, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2aeb, 5); calld(0x1007_6730, -0xd_c3c0);          /* call 0x10076730 */
            ii(0x1015_2af0, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x1015_2af4, 2); if(jzd(0x1015_2b2a, 0x34)) goto l_0x1015_2b2a; /* jz 0x10152b2a */
            ii(0x1015_2af6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2af9, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2afc, 5); calld(0x1007_6730, -0xd_c3d1);          /* call 0x10076730 */
            ii(0x1015_2b01, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1015_2b04, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2b07, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2b09, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2b0c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_2b0e, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1015_2b10, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_2b12, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2b15, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2b18, 5); calld(0x1007_6730, -0xd_c3ed);          /* call 0x10076730 */
            ii(0x1015_2b1d, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1015_2b20, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2b23, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_2b25, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_2b28, 2); jmpd(0x1015_2b80, 0x56); goto l_0x1015_2b80; /* jmp 0x10152b80 */
        l_0x1015_2b2a:
            ii(0x1015_2b2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2b2d, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2b30, 5); calld(0x1007_6730, -0xd_c405);          /* call 0x10076730 */
            ii(0x1015_2b35, 3); mov(ebx, memd_a32[ds, eax + 0x12]);     /* mov ebx, [eax+0x12] */
            ii(0x1015_2b38, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_2b3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2b3e, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2b41, 5); calld(0x1007_6730, -0xd_c416);          /* call 0x10076730 */
            ii(0x1015_2b46, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1015_2b49, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2b4c, 1); dec(ebx);                               /* dec ebx */
            ii(0x1015_2b4d, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x1015_2b50, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2b53, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2b56, 5); calld(0x1007_6730, -0xd_c42b);          /* call 0x10076730 */
            ii(0x1015_2b5b, 3); mov(ebx, memd_a32[ds, eax + 0x12]);     /* mov ebx, [eax+0x12] */
            ii(0x1015_2b5e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_2b61, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2b63, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2b66, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2b68, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_2b6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2b6d, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_2b70, 5); calld(0x1007_6730, -0xd_c445);          /* call 0x10076730 */
            ii(0x1015_2b75, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1015_2b78, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2b7b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_2b7d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1015_2b80:
            ii(0x1015_2b80, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2b83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2b85, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_2b86, 1); popd(edi);                              /* pop edi */
            ii(0x1015_2b87, 1); popd(esi);                              /* pop esi */
            ii(0x1015_2b88, 1); popd(edx);                              /* pop edx */
            ii(0x1015_2b89, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2b8a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_2b8b, 1); retd(); return;                         /* ret */
        }
    }
}
