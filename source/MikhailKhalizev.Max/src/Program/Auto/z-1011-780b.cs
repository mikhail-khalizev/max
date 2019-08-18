using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_780b-97cce241")]
        public void Method_1011_780b()
        {
            ii(0x1011_780b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_7810, 5); calld(Definitions.sys_check_available_stack_size, 0x4_e53d); /* call 0x10165d52 */
            ii(0x1011_7815, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7816, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7817, 1); pushd(edx);                             /* push edx */
            ii(0x1011_7818, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7819, 1); pushd(edi);                             /* push edi */
            ii(0x1011_781a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_781b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_781d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_7823, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_7826, 5); calld(0x100c_aa00, -0x4_ce2b);          /* call 0x100caa00 */
            ii(0x1011_782b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_7830, 1); pushd(eax);                             /* push eax */
            ii(0x1011_7831, 5); calld(0x100c_aa20, -0x4_ce16);          /* call 0x100caa20 */
            ii(0x1011_7836, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_7838, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_783a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_783c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_783f, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1011_7842, 5); calld(0x1011_5d23, -0x1b24);            /* call 0x10115d23 */
            ii(0x1011_7847, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_784a, 4); cmp(memb_a32[ds, eax + 0x14], 0);       /* cmp byte [eax+0x14], 0x0 */
            ii(0x1011_784e, 6); if(jzd(0x1011_78d5, 0x81)) goto l_0x1011_78d5; /* jz 0x101178d5 */
            ii(0x1011_7854, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_7856, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_7859, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_785c, 5); calld(0x1013_ad71, 0x2_3510);           /* call 0x1013ad71 */
            ii(0x1011_7861, 2); test(al, al);                           /* test al, al */
            ii(0x1011_7863, 2); if(jzd(0x1011_787c, 0x17)) goto l_0x1011_787c; /* jz 0x1011787c */
            ii(0x1011_7865, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_7868, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_786b, 5); calld(0x1007_6574, -0xa_12fc);          /* call 0x10076574 */
            ii(0x1011_7870, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1011_7873, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_7878, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_787a, 2); if(jgd(0x1011_787e, 0x2)) goto l_0x1011_787e; /* jg 0x1011787e */
        l_0x1011_787c:
            ii(0x1011_787c, 2); jmpd(0x1011_789c, 0x1e); goto l_0x1011_789c; /* jmp 0x1011789c */
        l_0x1011_787e:
            ii(0x1011_787e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_7880, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_7885, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_7888, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_788b, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_788e, 5); calld(0x1007_6574, -0xa_131f);          /* call 0x10076574 */
            ii(0x1011_7893, 5); calld(0x1007_6074, -0xa_1824);          /* call 0x10076074 */
            ii(0x1011_7898, 2); test(al, al);                           /* test al, al */
            ii(0x1011_789a, 2); if(jnzd(0x1011_789e, 0x2)) goto l_0x1011_789e; /* jnz 0x1011789e */
        l_0x1011_789c:
            ii(0x1011_789c, 2); jmpd(0x1011_78b0, 0x12); goto l_0x1011_78b0; /* jmp 0x101178b0 */
        l_0x1011_789e:
            ii(0x1011_789e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_78a1, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_78a4, 5); calld(0x1007_65d0, -0xa_12d9);          /* call 0x100765d0 */
            ii(0x1011_78a9, 5); calld(0x100f_f637, -0x1_8277);          /* call 0x100ff637 */
            ii(0x1011_78ae, 2); jmpd(0x1011_78d5, 0x25); goto l_0x1011_78d5; /* jmp 0x101178d5 */
        l_0x1011_78b0:
            ii(0x1011_78b0, 5); calld(0x1010_2acc, -0x1_4de9);          /* call 0x10102acc */
            ii(0x1011_78b5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_78b7, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_78b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_78bc, 3); mov(ebx, memd_a32[ds, eax + 0x10]);     /* mov ebx, [eax+0x10] */
            ii(0x1011_78bf, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_78c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_78c5, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1011_78c8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_78cb, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_78d0, 5); calld(0x1010_1620, -0x1_62b5);          /* call 0x10101620 */
        l_0x1011_78d5:
            ii(0x1011_78d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_78d7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_78d8, 1); popd(edi);                              /* pop edi */
            ii(0x1011_78d9, 1); popd(esi);                              /* pop esi */
            ii(0x1011_78da, 1); popd(edx);                              /* pop edx */
            ii(0x1011_78db, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_78dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_78dd, 1); retd(); return;                         /* ret */
        }
    }
}
