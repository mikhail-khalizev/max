using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e841a0e7-23a3-41b5-86bc-2459561eddaa")]
        public void Method_100f_28a2()
        {
            ii(0x100f_28a2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_28a7, 5); calld(Definitions.sys_check_available_stack_size, 0x734a6); /* call 0x10165d52 */
            ii(0x100f_28ac, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_28ad, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_28ae, 1); pushd(edx);                             /* push edx */
            ii(0x100f_28af, 1); pushd(esi);                             /* push esi */
            ii(0x100f_28b0, 1); pushd(edi);                             /* push edi */
            ii(0x100f_28b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_28b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_28b4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_28ba, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_28bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_28c0, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_28c4, 2); if(jnzd(0x100f_28d6, 0x10)) goto l_0x100f_28d6; /* jnz 0x100f28d6 */
            ii(0x100f_28c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_28c9, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100f_28cc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_28d1, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_28d4, 2); if(jnzd(0x100f_28d8, 0x2)) goto l_0x100f_28d8; /* jnz 0x100f28d8 */
        l_0x100f_28d6:
            ii(0x100f_28d6, 2); jmpd(0x100f_28e0, 0x8); goto l_0x100f_28e0; /* jmp 0x100f28e0 */
        l_0x100f_28d8:
            ii(0x100f_28d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_28db, 5); calld(0x100f_23e3, -0x4fd);             /* call 0x100f23e3 */
        l_0x100f_28e0:
            ii(0x100f_28e0, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100f_28e5, 5); calld(0x1007_5fdc, -0x7c90e);           /* call 0x10075fdc */
            ii(0x100f_28ea, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_28ed, 2); if(jnzd(0x100f_291c, 0x2d)) goto l_0x100f_291c; /* jnz 0x100f291c */
            ii(0x100f_28ef, 5); calld(0x100c_aa00, -0x27ef4);           /* call 0x100caa00 */
            ii(0x100f_28f4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_28f9, 1); pushd(eax);                             /* push eax */
            ii(0x100f_28fa, 5); calld(0x100c_aa20, -0x27edf);           /* call 0x100caa20 */
            ii(0x100f_28ff, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_2901, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_2903, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2905, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_2908, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_290b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_290e, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_2911, 6); mov(eax, memd_a32[ds, eax + 0x101c_81e3]); /* mov eax, [eax+0x101c81e3] */
            ii(0x100f_2917, 5); calld(0x1011_5d23, 0x23407);            /* call 0x10115d23 */
        l_0x100f_291c:
            ii(0x100f_291c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_291f, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_2923, 2); if(jzd(0x100f_292e, 0x9)) goto l_0x100f_292e; /* jz 0x100f292e */
            ii(0x100f_2925, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_2928, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x100f_292c, 2); if(jnzd(0x100f_2930, 0x2)) goto l_0x100f_2930; /* jnz 0x100f2930 */
        l_0x100f_292e:
            ii(0x100f_292e, 2); jmpd(0x100f_2939, 0x9); goto l_0x100f_2939; /* jmp 0x100f2939 */
        l_0x100f_2930:
            ii(0x100f_2930, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_2933, 4); cmp(memb_a32[ds, eax + 0x3d], 0x15);    /* cmp byte [eax+0x3d], 0x15 */
            ii(0x100f_2937, 2); if(jnzd(0x100f_293b, 0x2)) goto l_0x100f_293b; /* jnz 0x100f293b */
        l_0x100f_2939:
            ii(0x100f_2939, 2); jmpd(0x100f_2944, 0x9); goto l_0x100f_2944; /* jmp 0x100f2944 */
        l_0x100f_293b:
            ii(0x100f_293b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_293e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1f);    /* cmp byte [eax+0x3d], 0x1f */
            ii(0x100f_2942, 2); if(jnzd(0x100f_294c, 0x8)) goto l_0x100f_294c; /* jnz 0x100f294c */
        l_0x100f_2944:
            ii(0x100f_2944, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_2947, 5); calld(0x100f_21a4, -0x7a8);             /* call 0x100f21a4 */
        l_0x100f_294c:
            ii(0x100f_294c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_294e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_294f, 1); popd(edi);                              /* pop edi */
            ii(0x100f_2950, 1); popd(esi);                              /* pop esi */
            ii(0x100f_2951, 1); popd(edx);                              /* pop edx */
            ii(0x100f_2952, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_2953, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_2954, 1); retd(); return;                         /* ret */
        }
    }
}