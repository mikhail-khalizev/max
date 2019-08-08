using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7c5216f-04ce-4c45-91d4-62fcbb8440a0")]
        public void /* sys */ Method_1018_6a20()
        {
            ii(0x1018_6a20, 1); pushd(esi);                             /* push esi */
            ii(0x1018_6a21, 1); pushd(edi);                             /* push edi */
            ii(0x1018_6a22, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_6a23, 1); pushd(ds);                              /* push ds */
            ii(0x1018_6a24, 2); mov(ds, edx);                           /* mov ds, edx */
            ii(0x1018_6a26, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1018_6a28, 2); if(jzd_func(0x1018_6a1b, -0xf)) return; /* jz 0x10186a1b */
            ii(0x1018_6a2a, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_6a2c, 3); sub(esi, 0x4);                          /* sub esi, 0x4 */
            ii(0x1018_6a2f, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_6a31, 2); test(al, 0x1);                          /* test al, 0x1 */
            ii(0x1018_6a33, 2); if(jzd_func(0x1018_6a1b, -0x1a)) return; /* jz 0x10186a1b */
            ii(0x1018_6a35, 2); and(al, 0xfe);                          /* and al, 0xfe */
            ii(0x1018_6a37, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1018_6a39, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1018_6a3b, 6); test(memd_a32[ds, edi], 0x1);           /* test dword [edi], 0x1 */
            ii(0x1018_6a41, 2); if(jnzd(0x1018_6a62, 0x1f)) goto l_0x1018_6a62; /* jnz 0x10186a62 */
            ii(0x1018_6a43, 3); cmp(edi, memd_a32[ds, ebx + 0xc]);      /* cmp edi, [ebx+0xc] */
            ii(0x1018_6a46, 2); if(jnzd(0x1018_6a4b, 0x3)) goto l_0x1018_6a4b; /* jnz 0x10186a4b */
            ii(0x1018_6a48, 3); mov(memd_a32[ds, ebx + 0xc], esi);      /* mov [ebx+0xc], esi */
        l_0x1018_6a4b:
            ii(0x1018_6a4b, 2); add(eax, memd_a32[ds, edi]);            /* add eax, [edi] */
            ii(0x1018_6a4d, 2); mov(memd_a32[ds, esi], eax);            /* mov [esi], eax */
            ii(0x1018_6a4f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_6a50, 3); mov(ebx, memd_a32[ds, edi + 0x4]);      /* mov ebx, [edi+0x4] */
            ii(0x1018_6a53, 3); mov(edi, memd_a32[ds, edi + 0x8]);      /* mov edi, [edi+0x8] */
            ii(0x1018_6a56, 3); mov(memd_a32[ds, ebx + 0x8], edi);      /* mov [ebx+0x8], edi */
            ii(0x1018_6a59, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1018_6a5c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_6a5d, 3); dec(memd_a32[ds, ebx + 0x1c]);          /* dec dword [ebx+0x1c] */
            ii(0x1018_6a60, 2); jmpd(0x1018_6ade, 0x7c); goto l_0x1018_6ade; /* jmp 0x10186ade */
        l_0x1018_6a62:
            ii(0x1018_6a62, 2); mov(memd_a32[ds, esi], eax);            /* mov [esi], eax */
            ii(0x1018_6a64, 3); mov(edi, memd_a32[ds, ebx + 0xc]);      /* mov edi, [ebx+0xc] */
            ii(0x1018_6a67, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_6a69, 2); if(jaed(0x1018_6a79, 0xe)) goto l_0x1018_6a79; /* jae 0x10186a79 */
            ii(0x1018_6a6b, 3); cmp(esi, memd_a32[ds, edi + 0x4]);      /* cmp esi, [edi+0x4] */
            ii(0x1018_6a6e, 2); if(jad(0x1018_6ade, 0x6e)) goto l_0x1018_6ade; /* ja 0x10186ade */
            ii(0x1018_6a70, 3); mov(edi, memd_a32[ds, ebx + 0x28]);     /* mov edi, [ebx+0x28] */
            ii(0x1018_6a73, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_6a75, 2); if(jbd(0x1018_6ade, 0x67)) goto l_0x1018_6ade; /* jb 0x10186ade */
            ii(0x1018_6a77, 2); jmpd(0x1018_6a88, 0xf); goto l_0x1018_6a88; /* jmp 0x10186a88 */
        l_0x1018_6a79:
            ii(0x1018_6a79, 3); mov(edi, memd_a32[ds, edi + 0x8]);      /* mov edi, [edi+0x8] */
            ii(0x1018_6a7c, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_6a7e, 2); if(jbd(0x1018_6ade, 0x5e)) goto l_0x1018_6ade; /* jb 0x10186ade */
            ii(0x1018_6a80, 3); lea(edi, ebx + 0x20);                   /* lea edi, [ebx+0x20] */
            ii(0x1018_6a83, 3); cmp(esi, memd_a32[ds, ebx + 0x24]);     /* cmp esi, [ebx+0x24] */
            ii(0x1018_6a86, 2); if(jad(0x1018_6ade, 0x56)) goto l_0x1018_6ade; /* ja 0x10186ade */
        l_0x1018_6a88:
            ii(0x1018_6a88, 2); sub(edx, edx);                          /* sub edx, edx */
            ii(0x1018_6a8a, 3); mov(eax, memd_a32[ds, ebx + 0x18]);     /* mov eax, [ebx+0x18] */
            ii(0x1018_6a8d, 3); mov(ecx, memd_a32[ds, ebx + 0x1c]);     /* mov ecx, [ebx+0x1c] */
            ii(0x1018_6a90, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_6a91, 2); div(ecx);                               /* div ecx */
            ii(0x1018_6a93, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_6a94, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1018_6a96, 2); if(jaed(0x1018_6abd, 0x25)) goto l_0x1018_6abd; /* jae 0x10186abd */
            ii(0x1018_6a98, 3); mov(edx, memd_a32[ds, ebx + 0x18]);     /* mov edx, [ebx+0x18] */
            ii(0x1018_6a9b, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1018_6a9d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1018_6a9f, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1018_6aa1, 2); if(jad(0x1018_6aa5, 0x2)) goto l_0x1018_6aa5; /* ja 0x10186aa5 */
            ii(0x1018_6aa3, 2); sub(eax, eax);                          /* sub eax, eax */
        l_0x1018_6aa5:
            ii(0x1018_6aa5, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1018_6aa7, 2); add(edi, memd_a32[ds, esi]);            /* add edi, [esi] */
        l_0x1018_6aa9:
            ii(0x1018_6aa9, 2); mov(edx, memd_a32[ds, edi]);            /* mov edx, [edi] */
            ii(0x1018_6aab, 3); test(dl, 0x1);                          /* test dl, 0x1 */
            ii(0x1018_6aae, 2); if(jzd(0x1018_6ade, 0x2e)) goto l_0x1018_6ade; /* jz 0x10186ade */
            ii(0x1018_6ab0, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1018_6ab3, 2); if(jzd(0x1018_6abd, 0x8)) goto l_0x1018_6abd; /* jz 0x10186abd */
            ii(0x1018_6ab5, 3); and(dl, 0xfe);                          /* and dl, 0xfe */
            ii(0x1018_6ab8, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_6aba, 1); dec(eax);                               /* dec eax */
            ii(0x1018_6abb, 2); if(jnzd(0x1018_6aa9, -0x14)) goto l_0x1018_6aa9; /* jnz 0x10186aa9 */
        l_0x1018_6abd:
            ii(0x1018_6abd, 3); mov(edi, memd_a32[ds, ebx + 0xc]);      /* mov edi, [ebx+0xc] */
            ii(0x1018_6ac0, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_6ac2, 2); if(jaed(0x1018_6ac7, 0x3)) goto l_0x1018_6ac7; /* jae 0x10186ac7 */
            ii(0x1018_6ac4, 3); mov(edi, memd_a32[ds, ebx + 0x28]);     /* mov edi, [ebx+0x28] */
        l_0x1018_6ac7:
            ii(0x1018_6ac7, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_6ac9, 2); if(jbd(0x1018_6ade, 0x13)) goto l_0x1018_6ade; /* jb 0x10186ade */
            ii(0x1018_6acb, 3); mov(edi, memd_a32[ds, edi + 0x8]);      /* mov edi, [edi+0x8] */
            ii(0x1018_6ace, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_6ad0, 2); if(jbd(0x1018_6ade, 0xc)) goto l_0x1018_6ade; /* jb 0x10186ade */
            ii(0x1018_6ad2, 3); mov(edi, memd_a32[ds, edi + 0x8]);      /* mov edi, [edi+0x8] */
            ii(0x1018_6ad5, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_6ad7, 2); if(jbd(0x1018_6ade, 0x5)) goto l_0x1018_6ade; /* jb 0x10186ade */
            ii(0x1018_6ad9, 3); mov(edi, memd_a32[ds, edi + 0x8]);      /* mov edi, [edi+0x8] */
            ii(0x1018_6adc, 2); jmpd(0x1018_6ac7, -0x17); goto l_0x1018_6ac7; /* jmp 0x10186ac7 */
        l_0x1018_6ade:
            ii(0x1018_6ade, 3); mov(edx, memd_a32[ds, edi + 0x4]);      /* mov edx, [edi+0x4] */
            ii(0x1018_6ae1, 2); mov(ecx, memd_a32[ds, esi]);            /* mov ecx, [esi] */
            ii(0x1018_6ae3, 2); xchg(edx, edi);                         /* xchg edx, edi */
            ii(0x1018_6ae5, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_6ae7, 2); add(eax, memd_a32[ds, edi]);            /* add eax, [edi] */
            ii(0x1018_6ae9, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1018_6aeb, 2); if(jnzd(0x1018_6afd, 0x10)) goto l_0x1018_6afd; /* jnz 0x10186afd */
            ii(0x1018_6aed, 2); add(ecx, memd_a32[ds, edi]);            /* add ecx, [edi] */
            ii(0x1018_6aef, 2); mov(memd_a32[ds, edi], ecx);            /* mov [edi], ecx */
            ii(0x1018_6af1, 3); cmp(esi, memd_a32[ds, ebx + 0xc]);      /* cmp esi, [ebx+0xc] */
            ii(0x1018_6af4, 2); if(jnzd(0x1018_6af9, 0x3)) goto l_0x1018_6af9; /* jnz 0x10186af9 */
            ii(0x1018_6af6, 3); mov(memd_a32[ds, ebx + 0xc], edi);      /* mov [ebx+0xc], edi */
        l_0x1018_6af9:
            ii(0x1018_6af9, 2); mov(esi, edi);                          /* mov esi, edi */
            ii(0x1018_6afb, 2); jmpd(0x1018_6b0e, 0x11); goto l_0x1018_6b0e; /* jmp 0x10186b0e */
        l_0x1018_6afd:
            ii(0x1018_6afd, 3); inc(memd_a32[ds, ebx + 0x1c]);          /* inc dword [ebx+0x1c] */
            ii(0x1018_6b00, 3); mov(memd_a32[ds, esi + 0x8], edx);      /* mov [esi+0x8], edx */
            ii(0x1018_6b03, 3); mov(memd_a32[ds, esi + 0x4], edi);      /* mov [esi+0x4], edi */
            ii(0x1018_6b06, 3); mov(memd_a32[ds, edi + 0x8], esi);      /* mov [edi+0x8], esi */
            ii(0x1018_6b09, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_6b0b, 3); mov(memd_a32[ds, edi + 0x4], esi);      /* mov [edi+0x4], esi */
        l_0x1018_6b0e:
            ii(0x1018_6b0e, 3); dec(memd_a32[ds, ebx + 0x18]);          /* dec dword [ebx+0x18] */
            ii(0x1018_6b11, 3); cmp(esi, memd_a32[ds, ebx + 0xc]);      /* cmp esi, [ebx+0xc] */
            ii(0x1018_6b14, 2); if(jaed(0x1018_6b1e, 0x8)) goto l_0x1018_6b1e; /* jae 0x10186b1e */
            ii(0x1018_6b16, 3); cmp(ecx, memd_a32[ds, ebx + 0x10]);     /* cmp ecx, [ebx+0x10] */
            ii(0x1018_6b19, 2); if(jbed(0x1018_6b1e, 0x3)) goto l_0x1018_6b1e; /* jbe 0x10186b1e */
            ii(0x1018_6b1b, 3); mov(memd_a32[ds, ebx + 0x10], ecx);     /* mov [ebx+0x10], ecx */
        l_0x1018_6b1e:
            ii(0x1018_6b1e, 3); cmp(ecx, memd_a32[ds, ebx + 0x14]);     /* cmp ecx, [ebx+0x14] */
            ii(0x1018_6b21, 2); if(jbed_func(0x1018_6b26, 0x3)) return; /* jbe 0x10186b26 */
            ii(0x1018_6b23, 3); mov(memd_a32[ds, ebx + 0x14], ecx);     /* mov [ebx+0x14], ecx */
        }
    }
}
