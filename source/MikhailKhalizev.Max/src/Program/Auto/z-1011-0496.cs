using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d171f278-df69-44de-85ed-890d1f1ea4d6")]
        public void Method_1011_0496()
        {
            ii(0x1011_0496, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_049b, 5); calld(Definitions.sys_check_available_stack_size, 0x558b2); /* call 0x10165d52 */
            ii(0x1011_04a0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_04a1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_04a2, 1); pushd(edx);                             /* push edx */
            ii(0x1011_04a3, 1); pushd(esi);                             /* push esi */
            ii(0x1011_04a4, 1); pushd(edi);                             /* push edi */
            ii(0x1011_04a5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_04a6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_04a8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_04ae, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_04b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_04b4, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_04b6, 5); calld(0x1010_edfe, -0x16bd);            /* call 0x1010edfe */
            ii(0x1011_04bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_04be, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_04c0, 5); calld(0x1010_eda6, -0x171f);            /* call 0x1010eda6 */
            ii(0x1011_04c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_04c8, 6); mov(al, memb_a32[ds, eax + 0x141]);     /* mov al, [eax+0x141] */
            ii(0x1011_04ce, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_04d3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_04d5, 6); if(jzd(0x1011_058f, 0xb4)) goto l_0x1011_058f; /* jz 0x1011058f */
            ii(0x1011_04db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_04de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_04e0, 6); mov(dl, memb_a32[ds, eax + 0x142]);     /* mov dl, [eax+0x142] */
            ii(0x1011_04e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_04e9, 6); mov(al, memb_a32[ds, eax + 0x140]);     /* mov al, [eax+0x140] */
            ii(0x1011_04ef, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_04f1, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_04f3, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_04f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_04f9, 6); mov(dl, memb_a32[ds, eax + 0x142]);     /* mov dl, [eax+0x142] */
            ii(0x1011_04ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0502, 6); cmp(dl, memb_a32[ds, eax + 0x140]);     /* cmp dl, [eax+0x140] */
            ii(0x1011_0508, 2); if(jbd(0x1011_052a, 0x20)) goto l_0x1011_052a; /* jb 0x1011052a */
            ii(0x1011_050a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_050d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_050f, 6); mov(dl, memb_a32[ds, eax + 0x140]);     /* mov dl, [eax+0x140] */
            ii(0x1011_0515, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0518, 6); mov(al, memb_a32[ds, eax + 0x142]);     /* mov al, [eax+0x142] */
            ii(0x1011_051e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_0523, 3); add(edx, 0xc);                          /* add edx, 0xc */
            ii(0x1011_0526, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1011_0528, 2); if(jld(0x1011_052c, 0x2)) goto l_0x1011_052c; /* jl 0x1011052c */
        l_0x1011_052a:
            ii(0x1011_052a, 2); jmpd(0x1011_0554, 0x28); goto l_0x1011_0554; /* jmp 0x10110554 */
        l_0x1011_052c:
            ii(0x1011_052c, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1011_0531, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_0535, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0538, 5); calld(0x1011_0296, -0x2a7);             /* call 0x10110296 */
            ii(0x1011_053d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_0541, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0544, 6); mov(edx, memd_a32[ds, eax + 0x101c_4df4]); /* mov edx, [eax+0x101c4df4] */
            ii(0x1011_054a, 5); mov(eax, 0x101c_4e24);                  /* mov eax, 0x101c4e24 */
            ii(0x1011_054f, 5); calld(Definitions.sys_strcpy, 0x5597b); /* call 0x10165ecf */
        l_0x1011_0554:
            ii(0x1011_0554, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_0559, 5); calld(/* sys */ 0x1016_a24c, 0x59cee);  /* call 0x1016a24c */
            ii(0x1011_055e, 10); mov(memd_a32[ds, 0x101b_ad7c], 0x101c_4e24); /* mov dword [0x101bad7c], 0x101c4e24 */
            ii(0x1011_0568, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_056d, 1); pushd(eax);                             /* push eax */
            ii(0x1011_056e, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1011_0573, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_0578, 5); mov(edx, 0x101b_ad6c);                  /* mov edx, 0x101bad6c */
            ii(0x1011_057d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0580, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_0582, 5); calld(0x1010_8a05, -0x7b82);            /* call 0x10108a05 */
            ii(0x1011_0587, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_058a, 5); calld(0x1011_0357, -0x238);             /* call 0x10110357 */
        l_0x1011_058f:
            ii(0x1011_058f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0592, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_0594, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1011_0597, 5); calld(Definitions.sys_display_draw_0, 0x56ee8); /* call 0x10167484 */
            ii(0x1011_059c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_059e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_059f, 1); popd(edi);                              /* pop edi */
            ii(0x1011_05a0, 1); popd(esi);                              /* pop esi */
            ii(0x1011_05a1, 1); popd(edx);                              /* pop edx */
            ii(0x1011_05a2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_05a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_05a4, 1); retd(); return;                         /* ret */
        }
    }
}
