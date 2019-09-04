using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4fb5-83f41ab6")]
        public void Method_100a_4fb5()
        {
            ii(0x100a_4fb5, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_4fba, 5); call(Definitions.sys_check_available_stack_size, 0xc_0d93); /* call 0x10165d52 */
            ii(0x100a_4fbf, 1); push(ebx);                              /* push ebx */
            ii(0x100a_4fc0, 1); push(ecx);                              /* push ecx */
            ii(0x100a_4fc1, 1); push(esi);                              /* push esi */
            ii(0x100a_4fc2, 1); push(edi);                              /* push edi */
            ii(0x100a_4fc3, 1); push(ebp);                              /* push ebp */
            ii(0x100a_4fc4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4fc6, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_4fcc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_4fcf, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_4fd2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_4fd5, 5); call(0x1008_aef4, -0x1_a0e6);           /* call 0x1008aef4 */
            ii(0x100a_4fda, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_4fdc, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_4fdf, 5); call(0x1008_ae70, -0x1_a174);           /* call 0x1008ae70 */
            ii(0x100a_4fe4, 2); jmp(0x100a_4fee, 8); goto l_0x100a_4fee; /* jmp 0x100a4fee */
        l_0x100a_4fe6:
            ii(0x100a_4fe6, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_4fe9, 5); call(0x1007_6bf8, -0x2_e3f6);           /* call 0x10076bf8 */
        l_0x100a_4fee:
            ii(0x100a_4fee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4ff0, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_4ff3, 5); call(0x1013_ad71, 0x9_5d79);            /* call 0x1013ad71 */
            ii(0x100a_4ff8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4ffa, 2); if(jz(0x100a_5040, 0x44)) goto l_0x100a_5040; /* jz 0x100a5040 */
            ii(0x100a_4ffc, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_4fff, 5); call(0x1008_adc4, -0x1_a240);           /* call 0x1008adc4 */
            ii(0x100a_5004, 5); call(0x1008_ad90, -0x1_a279);           /* call 0x1008ad90 */
            ii(0x100a_5009, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100a_500d, 2); if(jnz(0x100a_502a, 0x1b)) goto l_0x100a_502a; /* jnz 0x100a502a */
            ii(0x100a_500f, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_5012, 5); call(0x1008_adc4, -0x1_a253);           /* call 0x1008adc4 */
            ii(0x100a_5017, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_501a, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_501d, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_5020, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_5023, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100a_5026, 2); cmp(al, 0x2d);                          /* cmp al, 0x2d */
            ii(0x100a_5028, 2); if(jnz(0x100a_502c, 2)) goto l_0x100a_502c; /* jnz 0x100a502c */
        l_0x100a_502a:
            ii(0x100a_502a, 2); jmp(0x100a_503e, 0x12); goto l_0x100a_503e; /* jmp 0x100a503e */
        l_0x100a_502c:
            ii(0x100a_502c, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_5031, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_5034, 5); call(0x1008_adc4, -0x1_a275);           /* call 0x1008adc4 */
            ii(0x100a_5039, 5); call(0x100a_b168, 0x612a);              /* call 0x100ab168 */
        l_0x100a_503e:
            ii(0x100a_503e, 2); jmp(0x100a_4fe6, -0x5a); goto l_0x100a_4fe6; /* jmp 0x100a4fe6 */
        l_0x100a_5040:
            ii(0x100a_5040, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_5043, 5); call(0x1008_aef4, -0x1_a154);           /* call 0x1008aef4 */
            ii(0x100a_5048, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_504a, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_504d, 5); call(0x100a_b1f8, 0x61a6);              /* call 0x100ab1f8 */
            ii(0x100a_5052, 2); jmp(0x100a_505c, 8); goto l_0x100a_505c; /* jmp 0x100a505c */
        l_0x100a_5054:
            ii(0x100a_5054, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_5057, 5); call(0x1007_6bf8, -0x2_e464);           /* call 0x10076bf8 */
        l_0x100a_505c:
            ii(0x100a_505c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_505e, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_5061, 5); call(0x1013_ad71, 0x9_5d0b);            /* call 0x1013ad71 */
            ii(0x100a_5066, 2); test(al, al);                           /* test al, al */
            ii(0x100a_5068, 2); if(jz(0x100a_50b2, 0x48)) goto l_0x100a_50b2; /* jz 0x100a50b2 */
            ii(0x100a_506a, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_506d, 5); call(0x1008_adc4, -0x1_a2ae);           /* call 0x1008adc4 */
            ii(0x100a_5072, 5); call(0x1008_ad90, -0x1_a2e7);           /* call 0x1008ad90 */
            ii(0x100a_5077, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100a_507b, 2); if(jnz(0x100a_5098, 0x1b)) goto l_0x100a_5098; /* jnz 0x100a5098 */
            ii(0x100a_507d, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_5080, 5); call(0x1008_adc4, -0x1_a2c1);           /* call 0x1008adc4 */
            ii(0x100a_5085, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_5088, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_508b, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_508e, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_5091, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100a_5094, 2); cmp(al, 0x2d);                          /* cmp al, 0x2d */
            ii(0x100a_5096, 2); if(jnz(0x100a_509a, 2)) goto l_0x100a_509a; /* jnz 0x100a509a */
        l_0x100a_5098:
            ii(0x100a_5098, 2); jmp(0x100a_50b0, 0x16); goto l_0x100a_50b0; /* jmp 0x100a50b0 */
        l_0x100a_509a:
            ii(0x100a_509a, 5); call(0x100a_b268, 0x61c9);              /* call 0x100ab268 */
            ii(0x100a_509f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_50a1, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_50a3, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_50a6, 5); call(0x1008_adc4, -0x1_a2e7);           /* call 0x1008adc4 */
            ii(0x100a_50ab, 5); call(0x100a_2a04, -0x26ac);             /* call 0x100a2a04 */
        l_0x100a_50b0:
            ii(0x100a_50b0, 2); jmp(0x100a_5054, -0x5e); goto l_0x100a_5054; /* jmp 0x100a5054 */
        l_0x100a_50b2:
            ii(0x100a_50b2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_50b5, 5); call(0x1008_aef4, -0x1_a1c6);           /* call 0x1008aef4 */
            ii(0x100a_50ba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_50bc, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_50bf, 5); call(0x100a_b1f8, 0x6134);              /* call 0x100ab1f8 */
            ii(0x100a_50c4, 2); jmp(0x100a_50ce, 8); goto l_0x100a_50ce; /* jmp 0x100a50ce */
        l_0x100a_50c6:
            ii(0x100a_50c6, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_50c9, 5); call(0x1007_6bf8, -0x2_e4d6);           /* call 0x10076bf8 */
        l_0x100a_50ce:
            ii(0x100a_50ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_50d0, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_50d3, 5); call(0x1013_ad71, 0x9_5c99);            /* call 0x1013ad71 */
            ii(0x100a_50d8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_50da, 2); if(jz(0x100a_5124, 0x48)) goto l_0x100a_5124; /* jz 0x100a5124 */
            ii(0x100a_50dc, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_50df, 5); call(0x1008_adc4, -0x1_a320);           /* call 0x1008adc4 */
            ii(0x100a_50e4, 5); call(0x1008_ad90, -0x1_a359);           /* call 0x1008ad90 */
            ii(0x100a_50e9, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100a_50ed, 2); if(jnz(0x100a_510a, 0x1b)) goto l_0x100a_510a; /* jnz 0x100a510a */
            ii(0x100a_50ef, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_50f2, 5); call(0x1008_adc4, -0x1_a333);           /* call 0x1008adc4 */
            ii(0x100a_50f7, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100a_50fa, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100a_50fd, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_5100, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100a_5103, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100a_5106, 2); cmp(al, 0x2d);                          /* cmp al, 0x2d */
            ii(0x100a_5108, 2); if(jz(0x100a_510c, 2)) goto l_0x100a_510c; /* jz 0x100a510c */
        l_0x100a_510a:
            ii(0x100a_510a, 2); jmp(0x100a_5122, 0x16); goto l_0x100a_5122; /* jmp 0x100a5122 */
        l_0x100a_510c:
            ii(0x100a_510c, 5); call(0x100a_b268, 0x6157);              /* call 0x100ab268 */
            ii(0x100a_5111, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5113, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_5115, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_5118, 5); call(0x1008_adc4, -0x1_a359);           /* call 0x1008adc4 */
            ii(0x100a_511d, 5); call(0x100a_2a04, -0x271e);             /* call 0x100a2a04 */
        l_0x100a_5122:
            ii(0x100a_5122, 2); jmp(0x100a_50c6, -0x5e); goto l_0x100a_50c6; /* jmp 0x100a50c6 */
        l_0x100a_5124:
            ii(0x100a_5124, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_5127, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_512a, 5); call(0x100a_ad20, 0x5bf1);              /* call 0x100aad20 */
            ii(0x100a_512f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_5131, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_5134, 5); call(0x100a_abfc, 0x5ac3);              /* call 0x100aabfc */
            ii(0x100a_5139, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_513b, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_513e, 5); call(0x100a_a178, 0x5035);              /* call 0x100aa178 */
            ii(0x100a_5143, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5145, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100a_5148, 5); call(0x1008_8bbc, -0x1_c591);           /* call 0x10088bbc */
            ii(0x100a_514d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_514f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_5150, 1); pop(edi);                               /* pop edi */
            ii(0x100a_5151, 1); pop(esi);                               /* pop esi */
            ii(0x100a_5152, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_5153, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_5154, 1); ret();                                  /* ret */
        }
    }
}
