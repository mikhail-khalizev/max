using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e3e00fd1-921e-4c03-9dab-f3afa7e5343a")]
        public void Method_100f_3711()
        {
            ii(0x100f_3711, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_3716, 5); calld(Definitions.sys_check_available_stack_size, 0x7_2637); /* call 0x10165d52 */
            ii(0x100f_371b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_371c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_371d, 1); pushd(edx);                             /* push edx */
            ii(0x100f_371e, 1); pushd(esi);                             /* push esi */
            ii(0x100f_371f, 1); pushd(edi);                             /* push edi */
            ii(0x100f_3720, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_3721, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_3723, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_3729, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_372c, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_372f, 5); mov(memb_a32[ds, 0x101c_388c], al);     /* mov [0x101c388c], al */
            ii(0x100f_3734, 5); mov(al, memb_a32[ds, 0x101c_388c]);     /* mov al, [0x101c388c] */
            ii(0x100f_3739, 5); mov(memb_a32[ds, 0x101b_886f], al);     /* mov [0x101b886f], al */
            ii(0x100f_373e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3740, 6); mov(dl, memb_a32[ds, 0x101c_388c]);     /* mov dl, [0x101c388c] */
            ii(0x100f_3746, 5); mov(eax, memd_a32[ds, 0x101b_886b]);    /* mov eax, [0x101b886b] */
            ii(0x100f_374b, 5); calld(0x100c_fb73, -0x2_3bdd);          /* call 0x100cfb73 */
            ii(0x100f_3750, 7); cmp(memb_a32[ds, 0x101c_388c], 0);      /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_3757, 2); if(jzd(0x100f_3769, 0x10)) goto l_0x100f_3769; /* jz 0x100f3769 */
            ii(0x100f_3759, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_375b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_3760, 5); calld(0x1013_ad71, 0x4_760c);           /* call 0x1013ad71 */
            ii(0x100f_3765, 2); test(al, al);                           /* test al, al */
            ii(0x100f_3767, 2); if(jnzd(0x100f_376b, 0x2)) goto l_0x100f_376b; /* jnz 0x100f376b */
        l_0x100f_3769:
            ii(0x100f_3769, 2); jmpd(0x100f_3785, 0x1a); goto l_0x100f_3785; /* jmp 0x100f3785 */
        l_0x100f_376b:
            ii(0x100f_376b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_3770, 5); calld(0x1007_6574, -0x7_d201);          /* call 0x10076574 */
            ii(0x100f_3775, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3777, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_377a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_377c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_3781, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_3783, 2); if(jnzd(0x100f_3787, 0x2)) goto l_0x100f_3787; /* jnz 0x100f3787 */
        l_0x100f_3785:
            ii(0x100f_3785, 2); jmpd(0x100f_37a1, 0x1a); goto l_0x100f_37a1; /* jmp 0x100f37a1 */
        l_0x100f_3787:
            ii(0x100f_3787, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_378c, 5); calld(0x1007_65d0, -0x7_d1c1);          /* call 0x100765d0 */
            ii(0x100f_3791, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_3793, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_3798, 5); calld(0x1007_62cc, -0x7_d4d1);          /* call 0x100762cc */
            ii(0x100f_379d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_379f, 2); if(jzd(0x100f_37a3, 0x2)) goto l_0x100f_37a3; /* jz 0x100f37a3 */
        l_0x100f_37a1:
            ii(0x100f_37a1, 2); jmpd(0x100f_37bb, 0x18); goto l_0x100f_37bb; /* jmp 0x100f37bb */
        l_0x100f_37a3:
            ii(0x100f_37a3, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_37a8, 5); calld(0x1007_65d0, -0x7_d1dd);          /* call 0x100765d0 */
            ii(0x100f_37ad, 5); mov(ebx, 0x101c_3924);                  /* mov ebx, 0x101c3924 */
            ii(0x100f_37b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_37b4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_37b6, 5); calld(0x1008_ab1c, -0x6_8c9f);          /* call 0x1008ab1c */
        l_0x100f_37bb:
            ii(0x100f_37bb, 7); cmp(memb_a32[ds, 0x101c_388c], 0);      /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_37c2, 2); if(jzd(0x100f_37cf, 0xb)) goto l_0x100f_37cf; /* jz 0x100f37cf */
            ii(0x100f_37c4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_37c6, 5); mov(al, memb_a32[ds, 0x101c_388a]);     /* mov al, [0x101c388a] */
            ii(0x100f_37cb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_37cd, 2); if(jzd(0x100f_37d1, 0x2)) goto l_0x100f_37d1; /* jz 0x100f37d1 */
        l_0x100f_37cf:
            ii(0x100f_37cf, 2); jmpd(0x100f_37dc, 0xb); goto l_0x100f_37dc; /* jmp 0x100f37dc */
        l_0x100f_37d1:
            ii(0x100f_37d1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_37d3, 5); mov(al, memb_a32[ds, 0x101c_3889]);     /* mov al, [0x101c3889] */
            ii(0x100f_37d8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_37da, 2); if(jzd(0x100f_37de, 0x2)) goto l_0x100f_37de; /* jz 0x100f37de */
        l_0x100f_37dc:
            ii(0x100f_37dc, 2); jmpd(0x100f_37f2, 0x14); goto l_0x100f_37f2; /* jmp 0x100f37f2 */
        l_0x100f_37de:
            ii(0x100f_37de, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_37e3, 5); calld(0x100f_4ba0, 0x13b8);             /* call 0x100f4ba0 */
            ii(0x100f_37e8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_37ed, 5); calld(0x100f_4831, 0x103f);             /* call 0x100f4831 */
        l_0x100f_37f2:
            ii(0x100f_37f2, 5); calld(0x100f_f5c1, 0xbdca);             /* call 0x100ff5c1 */
            ii(0x100f_37f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_37f9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_37fa, 1); popd(edi);                              /* pop edi */
            ii(0x100f_37fb, 1); popd(esi);                              /* pop esi */
            ii(0x100f_37fc, 1); popd(edx);                              /* pop edx */
            ii(0x100f_37fd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_37fe, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_37ff, 1); retd(); return;                         /* ret */
        }
    }
}
