using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8b383e36-8cda-4055-9644-23450e1d1ec5")]
        public void Method_1011_7a37()
        {
            ii(0x1011_7a37, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1011_7a3c, 5); calld(Definitions.sys_check_available_stack_size, 0x4e311); /* call 0x10165d52 */
            ii(0x1011_7a41, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7a42, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7a43, 1); pushd(edx);                             /* push edx */
            ii(0x1011_7a44, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7a45, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7a46, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7a47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7a49, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_7a4f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_7a52, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1011_7a56, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_7a59, 5); calld(0x1011_7dd4, 0x376);              /* call 0x10117dd4 */
            ii(0x1011_7a5e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_7a61, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1011_7a65, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_7a6c, 2); jmpd(0x1011_7a74, 0x6); goto l_0x1011_7a74; /* jmp 0x10117a74 */
        l_0x1011_7a6e:
            ii(0x1011_7a6e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_7a71, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1011_7a74:
            ii(0x1011_7a74, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_7a78, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_7a7b, 2); if(jged(0x1011_7ae8, 0x6b)) goto l_0x1011_7ae8; /* jge 0x10117ae8 */
            ii(0x1011_7a7d, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_7a81, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_7a84, 5); mov(edx, 0x101c_52bc);                  /* mov edx, 0x101c52bc */
            ii(0x1011_7a89, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_7a8b, 5); calld(0x1007_6b90, -0xa0f00);           /* call 0x10076b90 */
            ii(0x1011_7a90, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7a93, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_7a97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_7a9a, 5); calld(0x1013_c0fa, 0x2465b);            /* call 0x1013c0fa */
            ii(0x1011_7a9f, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_7aa3, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_7aa6, 5); mov(edx, 0x101c_52bc);                  /* mov edx, 0x101c52bc */
            ii(0x1011_7aab, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_7aad, 5); calld(0x1011_7c6c, 0x1ba);              /* call 0x10117c6c */
            ii(0x1011_7ab2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_7ab4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_7ab7, 5); calld(0x1011_7d58, 0x29c);              /* call 0x10117d58 */
            ii(0x1011_7abc, 2); jmpd(0x1011_7ac6, 0x8); goto l_0x1011_7ac6; /* jmp 0x10117ac6 */
        l_0x1011_7abe:
            ii(0x1011_7abe, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_7ac1, 5); calld(0x1007_6bf8, -0xa0ece);           /* call 0x10076bf8 */
        l_0x1011_7ac6:
            ii(0x1011_7ac6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_7ac8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_7acb, 5); calld(0x1013_ad71, 0x232a1);            /* call 0x1013ad71 */
            ii(0x1011_7ad0, 2); test(al, al);                           /* test al, al */
            ii(0x1011_7ad2, 2); if(jzd(0x1011_7ae6, 0x12)) goto l_0x1011_7ae6; /* jz 0x10117ae6 */
            ii(0x1011_7ad4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_7ad7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_7ada, 5); calld(0x1011_7d24, 0x245);              /* call 0x10117d24 */
            ii(0x1011_7adf, 5); calld(0x1011_78de, -0x206);             /* call 0x101178de */
            ii(0x1011_7ae4, 2); jmpd(0x1011_7abe, -0x28); goto l_0x1011_7abe; /* jmp 0x10117abe */
        l_0x1011_7ae6:
            ii(0x1011_7ae6, 2); jmpd(0x1011_7a6e, -0x7a); goto l_0x1011_7a6e; /* jmp 0x10117a6e */
        l_0x1011_7ae8:
            ii(0x1011_7ae8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_7aea, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_7aed, 5); calld(0x1011_7b8c, 0x9a);               /* call 0x10117b8c */
            ii(0x1011_7af2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7af4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7af5, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7af6, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7af7, 1); popd(edx);                              /* pop edx */
            ii(0x1011_7af8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7af9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7afa, 1); retd(); return;                         /* ret */
        }
    }
}
