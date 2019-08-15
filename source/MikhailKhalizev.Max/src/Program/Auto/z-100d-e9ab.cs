using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37788976-1e45-4716-b81a-eb82ddea61b7")]
        public void Method_100d_e9ab()
        {
            ii(0x100d_e9ab, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_e9b0, 5); calld(Definitions.sys_check_available_stack_size, 0x8_739d); /* call 0x10165d52 */
            ii(0x100d_e9b5, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_e9b6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_e9b7, 1); pushd(edx);                             /* push edx */
            ii(0x100d_e9b8, 1); pushd(esi);                             /* push esi */
            ii(0x100d_e9b9, 1); pushd(edi);                             /* push edi */
            ii(0x100d_e9ba, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_e9bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_e9bd, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_e9c3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_e9c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e9c9, 7); cmp(memb_a32[ds, eax + 0x39d], 0);      /* cmp byte [eax+0x39d], 0x0 */
            ii(0x100d_e9d0, 6); if(jzd(0x100d_ea65, 0x8f)) goto l_0x100d_ea65; /* jz 0x100dea65 */
            ii(0x100d_e9d6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_e9d9, 6); add(edx, 0x3af);                        /* add edx, 0x3af */
            ii(0x100d_e9df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e9e2, 6); mov(eax, memd_a32[ds, eax + 0x345]);    /* mov eax, [eax+0x345] */
            ii(0x100d_e9e8, 5); calld(0x100d_0264, -0xe789);            /* call 0x100d0264 */
            ii(0x100d_e9ed, 5); calld(0x100d_51c4, -0x982e);            /* call 0x100d51c4 */
            ii(0x100d_e9f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e9f4, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_e9f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e9f9, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_e9ff, 5); calld(0x100c_fb06, -0xeefe);            /* call 0x100cfb06 */
            ii(0x100d_ea04, 5); calld(0x100d_51c4, -0x9845);            /* call 0x100d51c4 */
            ii(0x100d_ea09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ea0b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_ea0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ea10, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_ea16, 5); calld(0x100c_fb06, -0xef15);            /* call 0x100cfb06 */
            ii(0x100d_ea1b, 5); calld(0x100d_51c4, -0x985c);            /* call 0x100d51c4 */
            ii(0x100d_ea20, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ea22, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_ea24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ea27, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_ea2d, 5); calld(0x100c_fb06, -0xef2c);            /* call 0x100cfb06 */
            ii(0x100d_ea32, 5); calld(0x100d_51c4, -0x9873);            /* call 0x100d51c4 */
            ii(0x100d_ea37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ea39, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_ea3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ea3e, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_ea44, 5); calld(0x100c_fb06, -0xef43);            /* call 0x100cfb06 */
            ii(0x100d_ea49, 5); calld(0x100d_51c4, -0x988a);            /* call 0x100d51c4 */
            ii(0x100d_ea4e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ea50, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_ea52, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ea55, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_ea5b, 5); calld(0x100c_fb06, -0xef5a);            /* call 0x100cfb06 */
            ii(0x100d_ea60, 5); jmpd(0x100d_eb0d, 0xa8); goto l_0x100d_eb0d; /* jmp 0x100deb0d */
        l_0x100d_ea65:
            ii(0x100d_ea65, 5); calld(0x100d_51e4, -0x9886);            /* call 0x100d51e4 */
            ii(0x100d_ea6a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_ea6c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_ea6e, 5); calld(0x100d_5204, -0x986f);            /* call 0x100d5204 */
            ii(0x100d_ea73, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ea75, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_ea77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ea7a, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_ea80, 5); calld(0x100c_fa7c, -0xf009);            /* call 0x100cfa7c */
            ii(0x100d_ea85, 5); calld(0x100d_51e4, -0x98a6);            /* call 0x100d51e4 */
            ii(0x100d_ea8a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_ea8c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_ea8e, 5); calld(0x100d_5204, -0x988f);            /* call 0x100d5204 */
            ii(0x100d_ea93, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ea95, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_ea97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_ea9a, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_eaa0, 5); calld(0x100c_fa7c, -0xf029);            /* call 0x100cfa7c */
            ii(0x100d_eaa5, 5); calld(0x100d_51e4, -0x98c6);            /* call 0x100d51e4 */
            ii(0x100d_eaaa, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_eaac, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_eaae, 5); calld(0x100d_5204, -0x98af);            /* call 0x100d5204 */
            ii(0x100d_eab3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_eab5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_eab7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_eaba, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_eac0, 5); calld(0x100c_fa7c, -0xf049);            /* call 0x100cfa7c */
            ii(0x100d_eac5, 5); calld(0x100d_51e4, -0x98e6);            /* call 0x100d51e4 */
            ii(0x100d_eaca, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_eacc, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_eace, 5); calld(0x100d_5204, -0x98cf);            /* call 0x100d5204 */
            ii(0x100d_ead3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ead5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_ead7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_eada, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_eae0, 5); calld(0x100c_fa7c, -0xf069);            /* call 0x100cfa7c */
            ii(0x100d_eae5, 5); calld(0x100d_51e4, -0x9906);            /* call 0x100d51e4 */
            ii(0x100d_eaea, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_eaec, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_eaee, 5); calld(0x100d_5204, -0x98ef);            /* call 0x100d5204 */
            ii(0x100d_eaf3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_eaf5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_eaf7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_eafa, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_eb00, 5); calld(0x100c_fa7c, -0xf089);            /* call 0x100cfa7c */
            ii(0x100d_eb05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_eb08, 5); calld(0x100d_8e05, -0x5d08);            /* call 0x100d8e05 */
        l_0x100d_eb0d:
            ii(0x100d_eb0d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_eb0f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_eb10, 1); popd(edi);                              /* pop edi */
            ii(0x100d_eb11, 1); popd(esi);                              /* pop esi */
            ii(0x100d_eb12, 1); popd(edx);                              /* pop edx */
            ii(0x100d_eb13, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_eb14, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_eb15, 1); retd(); return;                         /* ret */
        }
    }
}
