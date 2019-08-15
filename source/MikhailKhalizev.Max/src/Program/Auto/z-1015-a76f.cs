using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2f469be2-6fec-4956-9152-c94ba8f8e1c6")]
        public void Method_1015_a76f()
        {
            ii(0x1015_a76f, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1015_a774, 5); calld(Definitions.sys_check_available_stack_size, 0xb5d9); /* call 0x10165d52 */
            ii(0x1015_a779, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_a77a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_a77b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_a77c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_a77d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_a77e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_a780, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_a786, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_a789, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_a78c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_a78f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_a792, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_a797, 5); calld(0x100f_448c, -0x6_6310);          /* call 0x100f448c */
            ii(0x1015_a79c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a79f, 4); mov(ax, memw_a32[ds, eax + 0x41]);      /* mov ax, [eax+0x41] */
            ii(0x1015_a7a3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_a7a6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a7a9, 4); mov(ax, memw_a32[ds, eax + 0x43]);      /* mov ax, [eax+0x43] */
            ii(0x1015_a7ad, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_a7b0, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1015_a7b3, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_a7b6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a7b9, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_a7bc, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_a7be, 1); cwde();                                 /* cwde */
            ii(0x1015_a7bf, 5); calld(0x1015_a0f9, -0x6cb);             /* call 0x1015a0f9 */
            ii(0x1015_a7c4, 2); test(al, al);                           /* test al, al */
            ii(0x1015_a7c6, 2); if(jnzd(0x1015_a7ed, 0x25)) goto l_0x1015_a7ed; /* jnz 0x1015a7ed */
            ii(0x1015_a7c8, 5); calld(0x100c_aa00, -0x8_fdcd);          /* call 0x100caa00 */
            ii(0x1015_a7cd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_a7d2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a7d3, 5); calld(0x100c_aa20, -0x8_fdb8);          /* call 0x100caa20 */
            ii(0x1015_a7d8, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_a7da, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_a7dc, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1015_a7e1, 5); mov(eax, StringDefinitions.NeedALocationToPutThePowerGenerator); /* mov eax, 0x101b2702 */
            ii(0x1015_a7e6, 5); calld(0x1011_5d23, -0x4_4ac8);          /* call 0x10115d23 */
            ii(0x1015_a7eb, 2); jmpd(0x1015_a863, 0x76); goto l_0x1015_a863; /* jmp 0x1015a863 */
        l_0x1015_a7ed:
            ii(0x1015_a7ed, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1015_a7f2, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1015_a7f7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a7fa, 5); calld(0x1016_2f96, 0x8797);             /* call 0x10162f96 */
            ii(0x1015_a7ff, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a802, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a803, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a806, 3); mov(eax, memd_a32[ds, eax + 0x41]);     /* mov eax, [eax+0x41] */
            ii(0x1015_a809, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_a80c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a80d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a810, 3); mov(ecx, memd_a32[ds, eax + 0x3f]);     /* mov ecx, [eax+0x3f] */
            ii(0x1015_a813, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1015_a816, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_a818, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_a81d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_a820, 5); mov(edx, 0xf);                          /* mov edx, 0xf */
            ii(0x1015_a825, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_a828, 5); calld(0x1015_a6aa, -0x183);             /* call 0x1015a6aa */
            ii(0x1015_a82d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_a82f, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x1015_a834, 5); calld(0x1008_ac18, -0xc_fc21);          /* call 0x1008ac18 */
            ii(0x1015_a839, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a83b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_a83e, 5); calld(0x1007_5f2c, -0xe_4917);          /* call 0x10075f2c */
            ii(0x1015_a843, 5); calld(0x100c_aa00, -0x8_fe48);          /* call 0x100caa00 */
            ii(0x1015_a848, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_a84d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a84e, 5); calld(0x100c_aa20, -0x8_fe33);          /* call 0x100caa20 */
            ii(0x1015_a853, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_a855, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_a857, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a859, 5); mov(eax, StringDefinitions.ClickInsideTapeToBeginTransformation); /* mov eax, 0x101b272e */
            ii(0x1015_a85e, 5); calld(0x1011_5d23, -0x4_4b40);          /* call 0x10115d23 */
        l_0x1015_a863:
            ii(0x1015_a863, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_a865, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_a866, 1); popd(edi);                              /* pop edi */
            ii(0x1015_a867, 1); popd(esi);                              /* pop esi */
            ii(0x1015_a868, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_a869, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_a86a, 1); retd(); return;                         /* ret */
        }
    }
}
