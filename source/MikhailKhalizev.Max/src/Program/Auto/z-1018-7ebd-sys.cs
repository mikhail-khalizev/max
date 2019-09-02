using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7ebd-f96a4b36")]
        public void /* sys */ Method_1018_7ebd()
        {
            ii(0x1018_7ebd, 1); push(esi);                              /* push esi */
            ii(0x1018_7ebe, 1); push(edi);                              /* push edi */
            ii(0x1018_7ebf, 1); push(ebx);                              /* push ebx */
            ii(0x1018_7ec0, 1); pushd(es);                              /* push es */
            ii(0x1018_7ec1, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1018_7ec3, 2); mov(dl, al);                            /* mov dl, al */
        l_0x1018_7ec5:
            ii(0x1018_7ec5, 6); mov(esi, 0x101c_3052);                  /* mov esi, 0x101c3052 */
            ii(0x1018_7ecb, 6); mov(edi, 0x101c_3064);                  /* mov edi, 0x101c3064 */
            ii(0x1018_7ed1, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1018_7ed3, 2); mov(al, dl);                            /* mov al, dl */
        l_0x1018_7ed5:
            ii(0x1018_7ed5, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_7ed7, 2); if(jae(0x1018_7eed, 0x14)) goto l_0x1018_7eed; /* jae 0x10187eed */
            ii(0x1018_7ed9, 3); cmp(memb[ds, esi], 2);                  /* cmp byte [esi], 0x2 */
            ii(0x1018_7edc, 2); if(jz(0x1018_7ee8, 0xa)) goto l_0x1018_7ee8; /* jz 0x10187ee8 */
            ii(0x1018_7ede, 3); cmp(al, memb[ds, esi + 1]);             /* cmp al, [esi+0x1] */
            ii(0x1018_7ee1, 2); if(ja(0x1018_7ee8, 5)) goto l_0x1018_7ee8; /* ja 0x10187ee8 */
            ii(0x1018_7ee3, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1018_7ee5, 3); mov(al, memb[ds, esi + 1]);             /* mov al, [esi+0x1] */
        l_0x1018_7ee8:
            ii(0x1018_7ee8, 3); add(esi, 6);                            /* add esi, 0x6 */
            ii(0x1018_7eeb, 2); jmp(0x1018_7ed5, -0x18); goto l_0x1018_7ed5; /* jmp 0x10187ed5 */
        l_0x1018_7eed:
            ii(0x1018_7eed, 2); cmp(ebx, edi);                          /* cmp ebx, edi */
            ii(0x1018_7eef, 2); if(jz(0x1018_7f07, 0x16)) goto l_0x1018_7f07; /* jz 0x10187f07 */
            ii(0x1018_7ef1, 2); cmp(al, dh);                            /* cmp al, dh */
            ii(0x1018_7ef3, 2); if(ja(0x1018_7f02, 0xd)) goto l_0x1018_7f02; /* ja 0x10187f02 */
            ii(0x1018_7ef5, 3); mov(eax, memd[ds, ebx + 2]);            /* mov eax, [ebx+0x2] */
            ii(0x1018_7ef8, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1018_7efa, 2); if(jz(0x1018_7f02, 6)) goto l_0x1018_7f02; /* jz 0x10187f02 */
            ii(0x1018_7efc, 1); pushd(ds);                              /* push ds */
            ii(0x1018_7efd, 1); popd(es);                               /* pop es */
            ii(0x1018_7efe, 1); push(edx);                              /* push edx */
            ii(0x1018_7eff, 2); call_abs(eax);                          /* call eax */
            ii(0x1018_7f01, 1); pop(edx);                               /* pop edx */
        l_0x1018_7f02:
            ii(0x1018_7f02, 3); mov(memb[ds, ebx], 2);                  /* mov byte [ebx], 0x2 */
            ii(0x1018_7f05, 2); jmp(0x1018_7ec5, -0x42); goto l_0x1018_7ec5; /* jmp 0x10187ec5 */
        l_0x1018_7f07:
            ii(0x1018_7f07, 1); popd(es);                               /* pop es */
            ii(0x1018_7f08, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_7f09, 1); pop(edi);                               /* pop edi */
            ii(0x1018_7f0a, 1); pop(esi);                               /* pop esi */
            ii(0x1018_7f0b, 1); ret();                                  /* ret */
        }
    }
}
