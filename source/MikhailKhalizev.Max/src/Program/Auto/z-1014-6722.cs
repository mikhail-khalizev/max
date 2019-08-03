using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b62d05a4-5e2e-48c0-9d14-f619954bdb21")]
        public void Method_1014_6722()
        {
            ii(0x1014_6722, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_6727, 5); calld(Definitions.sys_check_available_stack_size, 0x1f626); /* call 0x10165d52 */
            ii(0x1014_672c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_672d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_672e, 1); pushd(edx);                             /* push edx */
            ii(0x1014_672f, 1); pushd(esi);                             /* push esi */
            ii(0x1014_6730, 1); pushd(edi);                             /* push edi */
            ii(0x1014_6731, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_6732, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6734, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_673a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_673d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6740, 4); cmp(memd_a32[ds, eax + 0x1c], -0x1 /* 0xff */); /* cmp dword [eax+0x1c], 0xffffffff */
            ii(0x1014_6744, 6); if(jzd(0x1014_6817, 0xcd)) goto l_0x1014_6817; /* jz 0x10146817 */
            ii(0x1014_674a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_674d, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_6750, 5); calld(0x100e_aef0, -0x5b865);           /* call 0x100eaef0 */
            ii(0x1014_6755, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6757, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_675a, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x1014_675e, 6); if(jgd(0x1014_67f1, 0x8d)) goto l_0x1014_67f1; /* jg 0x101467f1 */
            ii(0x1014_6764, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6767, 3); inc(memd_a32[ds, eax + 0x16]);          /* inc dword [eax+0x16] */
            ii(0x1014_676a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_676d, 6); mov(memw_a32[ds, eax + 0x1a], 0);       /* mov word [eax+0x1a], 0x0 */
            ii(0x1014_6773, 5); mov(edx, 0x101a_d020);                  /* mov edx, 0x101ad020 */ /* "" */
            ii(0x1014_6778, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_677b, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_677e, 5); calld(0x1014_21cb, -0x45b8);            /* call 0x101421cb */
            ii(0x1014_6783, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6786, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_6788, 5); calld(/* sys */ 0x1017_1f05, 0x2b778);  /* call 0x10171f05 */
            ii(0x1014_678d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1014_6790:
            ii(0x1014_6790, 4); cmp(memd_a32[ss, ebp - 0x8], 0xa);      /* cmp dword [ebp-0x8], 0xa */
            ii(0x1014_6794, 2); if(jzd(0x1014_679c, 0x6)) goto l_0x1014_679c; /* jz 0x1014679c */
            ii(0x1014_6796, 4); cmp(memd_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp dword [ebp-0x8], 0xffffffff */
            ii(0x1014_679a, 2); if(jnzd(0x1014_679e, 0x2)) goto l_0x1014_679e; /* jnz 0x1014679e */
        l_0x1014_679c:
            ii(0x1014_679c, 2); jmpd(0x1014_67bd, 0x1f); goto l_0x1014_67bd; /* jmp 0x101467bd */
        l_0x1014_679e:
            ii(0x1014_679e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_67a0, 3); mov(dl, memb_a32[ss, ebp - 0x8]);       /* mov dl, [ebp-0x8] */
            ii(0x1014_67a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_67a6, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_67a9, 5); calld(Definitions.my_string_append_char, -0x49c4); /* call 0x10141dea */
            ii(0x1014_67ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_67b1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_67b3, 5); calld(/* sys */ 0x1017_1f05, 0x2b74d);  /* call 0x10171f05 */
            ii(0x1014_67b8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_67bb, 2); jmpd(0x1014_6790, -0x2d); goto l_0x1014_6790; /* jmp 0x10146790 */
        l_0x1014_67bd:
            ii(0x1014_67bd, 4); cmp(memd_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp dword [ebp-0x8], 0xffffffff */
            ii(0x1014_67c1, 2); if(jzd(0x1014_67d5, 0x12)) goto l_0x1014_67d5; /* jz 0x101467d5 */
            ii(0x1014_67c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_67c5, 3); mov(dl, memb_a32[ss, ebp - 0x8]);       /* mov dl, [ebp-0x8] */
            ii(0x1014_67c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_67cb, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_67ce, 5); calld(Definitions.my_string_append_char, -0x49e9); /* call 0x10141dea */
            ii(0x1014_67d3, 2); jmpd(0x1014_67f1, 0x1c); goto l_0x1014_67f1; /* jmp 0x101467f1 */
        l_0x1014_67d5:
            ii(0x1014_67d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_67d8, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_67db, 5); calld(0x100e_aef0, -0x5b8f0);           /* call 0x100eaef0 */
            ii(0x1014_67e0, 1); cwde();                                 /* cwde */
            ii(0x1014_67e1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_67e3, 2); if(jnzd(0x1014_67f1, 0xc)) goto l_0x1014_67f1; /* jnz 0x101467f1 */
            ii(0x1014_67e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_67e8, 7); mov(memd_a32[ds, eax + 0x1c], 0xffff_ffff); /* mov dword [eax+0x1c], 0xffffffff */
            ii(0x1014_67ef, 2); jmpd(0x1014_6817, 0x26); goto l_0x1014_6817; /* jmp 0x10146817 */
        l_0x1014_67f1:
            ii(0x1014_67f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_67f4, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1014_67f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_67fb, 4); inc(memw_a32[ds, eax + 0x1a]);          /* inc word [eax+0x1a] */
            ii(0x1014_67ff, 3); movsx(edx, dx);                         /* movsx edx, dx */
            ii(0x1014_6802, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6805, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_6808, 5); calld(Definitions.my_string_get, -0x457b); /* call 0x10142292 */
            ii(0x1014_680d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_680f, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1014_6811, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6814, 3); mov(memd_a32[ds, eax + 0x1c], edx);     /* mov [eax+0x1c], edx */
        l_0x1014_6817:
            ii(0x1014_6817, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6819, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_681a, 1); popd(edi);                              /* pop edi */
            ii(0x1014_681b, 1); popd(esi);                              /* pop esi */
            ii(0x1014_681c, 1); popd(edx);                              /* pop edx */
            ii(0x1014_681d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_681e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_681f, 1); retd(); return;                         /* ret */
        }
    }
}