using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8905-9e797e44")]
        public void Method_1010_8905()
        {
            ii(0x1010_8905, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1010_890a, 5); calld(Definitions.sys_check_available_stack_size, 0x5_d443); /* call 0x10165d52 */
            ii(0x1010_890f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_8910, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_8911, 1); pushd(esi);                             /* push esi */
            ii(0x1010_8912, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8913, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8914, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8916, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_891c, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1010_891f, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1010_8922, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_8924, 5); mov(al, memb_a32[ds, 0x101c_3d0c]);     /* mov al, [0x101c3d0c] */
            ii(0x1010_8929, 3); sub(eax, 0x40);                         /* sub eax, 0x40 */
            ii(0x1010_892c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_892f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_8932, 5); calld(/* sys */ 0x1017_9230, 0x7_08f9); /* call 0x10179230 */
            ii(0x1010_8937, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1010_893a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_893d, 5); calld(/* sys */ 0x1017_9244, 0x7_0902); /* call 0x10179244 */
            ii(0x1010_8942, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_8945, 5); calld(/* sys */ 0x1017_9230, 0x7_08e6); /* call 0x10179230 */
        l_0x1010_894a:
            ii(0x1010_894a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_894d, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1010_8950, 2); if(jnzd(0x1010_897a, 0x28)) goto l_0x1010_897a; /* jnz 0x1010897a */
            ii(0x1010_8952, 5); mov(eax, 0x101c_3d0c);                  /* mov eax, 0x101c3d0c */
            ii(0x1010_8957, 5); calld(/* sys */ 0x1017_9368, 0x7_0a0c); /* call 0x10179368 */
            ii(0x1010_895c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_895e, 2); if(jnzd(0x1010_897a, 0x1a)) goto l_0x1010_897a; /* jnz 0x1010897a */
            ii(0x1010_8960, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_8964, 2); if(jzd(0x1010_8971, 0xb)) goto l_0x1010_8971; /* jz 0x10108971 */
            ii(0x1010_8966, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1010_8969, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_896c, 5); calld(/* sys */ 0x1017_9244, 0x7_08d3); /* call 0x10179244 */
        l_0x1010_8971:
            ii(0x1010_8971, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1010_8978, 2); jmpd(0x1010_89a5, 0x2b); goto l_0x1010_89a5; /* jmp 0x101089a5 */
        l_0x1010_897a:
            ii(0x1010_897a, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_897e, 2); if(jzd(0x1010_8993, 0x13)) goto l_0x1010_8993; /* jz 0x10108993 */
            ii(0x1010_8980, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_8985, 5); mov(eax, StringDefinitions.PleaseInsertTheMAXCdAndTryAgain); /* mov eax, 0x101a4540 */
            ii(0x1010_898a, 5); calld(0x1011_7036, 0xe6a7);             /* call 0x10117036 */
            ii(0x1010_898f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8991, 2); if(jnzd(0x1010_894a, -0x49)) goto l_0x1010_894a; /* jnz 0x1010894a */
        l_0x1010_8993:
            ii(0x1010_8993, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1010_8996, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_8999, 5); calld(/* sys */ 0x1017_9244, 0x7_08a6); /* call 0x10179244 */
            ii(0x1010_899e, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x1010_89a5:
            ii(0x1010_89a5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_89a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_89aa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_89ab, 1); popd(edi);                              /* pop edi */
            ii(0x1010_89ac, 1); popd(esi);                              /* pop esi */
            ii(0x1010_89ad, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_89ae, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_89af, 1); retd(); return;                         /* ret */
        }
    }
}
