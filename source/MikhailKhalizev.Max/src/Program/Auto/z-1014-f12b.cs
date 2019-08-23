using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f12b-ca9499a3")]
        public void Method_1014_f12b()
        {
            ii(0x1014_f12b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_f130, 5); calld(Definitions.sys_check_available_stack_size, 0x1_6c1d); /* call 0x10165d52 */
            ii(0x1014_f135, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_f136, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_f137, 1); pushd(edx);                             /* push edx */
            ii(0x1014_f138, 1); pushd(esi);                             /* push esi */
            ii(0x1014_f139, 1); pushd(edi);                             /* push edi */
            ii(0x1014_f13a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_f13b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_f13d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_f143, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_f146, 5); mov(eax, 0x56);                         /* mov eax, 0x56 */
            ii(0x1014_f14b, 5); calld(0x1007_5fdc, -0xd_9174);          /* call 0x10075fdc */
            ii(0x1014_f150, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_f152, 2); if(jzd(0x1014_f165, 0x11)) goto l_0x1014_f165; /* jz 0x1014f165 */
            ii(0x1014_f154, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_f159, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_f15c, 5); calld(0x1008_b4b4, -0xc_3cad);          /* call 0x1008b4b4 */
            ii(0x1014_f161, 2); test(al, al);                           /* test al, al */
            ii(0x1014_f163, 2); if(jzd(0x1014_f16a, 0x5)) goto l_0x1014_f16a; /* jz 0x1014f16a */
        l_0x1014_f165:
            ii(0x1014_f165, 5); jmpd(0x1014_f1e9, 0x7f); goto l_0x1014_f1e9; /* jmp 0x1014f1e9 */
        l_0x1014_f16a:
            ii(0x1014_f16a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_f16c, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1014_f171, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_f173, 2); if(jzd(0x1014_f1a4, 0x2f)) goto l_0x1014_f1a4; /* jz 0x1014f1a4 */
            ii(0x1014_f175, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_f178, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_f17a, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1014_f17d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_f17f, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_f184, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_f186, 2); if(jzd(0x1014_f1a4, 0x1c)) goto l_0x1014_f1a4; /* jz 0x1014f1a4 */
            ii(0x1014_f188, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_f18a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_f18f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_f195, 6); mov(al, memb_a32[ds, eax + 0x101c_a491]); /* mov al, [eax+0x101ca491] */
            ii(0x1014_f19b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_f1a0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_f1a2, 2); if(jzd(0x1014_f1e9, 0x45)) goto l_0x1014_f1e9; /* jz 0x1014f1e9 */
        l_0x1014_f1a4:
            ii(0x1014_f1a4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_f1a6, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_f1ab, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1014_f1ae, 7); cmp(memb_a32[ds, eax + 0xab], 0);       /* cmp byte [eax+0xab], 0x0 */
            ii(0x1014_f1b5, 2); if(jzd(0x1014_f1e9, 0x32)) goto l_0x1014_f1e9; /* jz 0x1014f1e9 */
            ii(0x1014_f1b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_f1ba, 5); calld(0x1010_1103, -0x4_e0bc);          /* call 0x10101103 */
            ii(0x1014_f1bf, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1014_f1c2, 2); if(jnzd(0x1014_f1e9, 0x25)) goto l_0x1014_f1e9; /* jnz 0x1014f1e9 */
            ii(0x1014_f1c4, 5); calld(0x1010_2acc, -0x4_c6fd);          /* call 0x10102acc */
            ii(0x1014_f1c9, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_f1cb, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_f1cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_f1d0, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1014_f1d3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_f1d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_f1d9, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1014_f1dc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_f1df, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_f1e4, 5); calld(0x1010_1620, -0x4_dbc9);          /* call 0x10101620 */
        l_0x1014_f1e9:
            ii(0x1014_f1e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f1eb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_f1ec, 1); popd(edi);                              /* pop edi */
            ii(0x1014_f1ed, 1); popd(esi);                              /* pop esi */
            ii(0x1014_f1ee, 1); popd(edx);                              /* pop edx */
            ii(0x1014_f1ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_f1f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_f1f1, 1); retd();                                 /* ret */
        }
    }
}
