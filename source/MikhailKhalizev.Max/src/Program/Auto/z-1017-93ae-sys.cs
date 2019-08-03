using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0956d977-f757-4dc4-bdd6-fc6f7acee54d")]
        public void /* sys */ Method_1017_93ae()
        {
            ii(0x1017_93ae, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_93af, 1); pushd(esi);                             /* push esi */
            ii(0x1017_93b0, 1); pushd(edi);                             /* push edi */
            ii(0x1017_93b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_93b2, 3); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1017_93b5, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1017_93b7, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1017_93b9, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_93bb, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1017_93bd, 4); lea(ecx, esp + 0x1);                    /* lea ecx, [esp+0x1] */
            ii(0x1017_93c1, 3); mov(memb_a32[ss, esp], dl);             /* mov [esp], dl */
        l_0x1017_93c4:
            ii(0x1017_93c4, 4); lea(ebx, esp + 0x24);                   /* lea ebx, [esp+0x24] */
            ii(0x1017_93c8, 4); mov(memd_a32[ss, esp + 0x24], edi);     /* mov [esp+0x24], edi */
            ii(0x1017_93cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_93ce, 2); div(memd_a32[ds, ebx]);                 /* div dword [ebx] */
            ii(0x1017_93d0, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1017_93d2, 7); mov(al, memb_a32[cs, edx + /* sys */ 0x1017_9389]); /* mov al, [cs:edx+0x10179389] */
            ii(0x1017_93d9, 2); mov(memb_a32[ds, ecx], al);             /* mov [ecx], al */
            ii(0x1017_93db, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1017_93df, 1); inc(ecx);                               /* inc ecx */
            ii(0x1017_93e0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_93e2, 2); if(jnzd(0x1017_93c4, -0x20)) goto l_0x1017_93c4; /* jnz 0x101793c4 */
        l_0x1017_93e4:
            ii(0x1017_93e4, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_93e5, 2); mov(al, memb_a32[ds, ecx]);             /* mov al, [ecx] */
            ii(0x1017_93e7, 2); mov(memb_a32[ds, esi], al);             /* mov [esi], al */
            ii(0x1017_93e9, 1); inc(esi);                               /* inc esi */
            ii(0x1017_93ea, 2); test(al, al);                           /* test al, al */
            ii(0x1017_93ec, 2); if(jnzd(0x1017_93e4, -0xa)) goto l_0x1017_93e4; /* jnz 0x101793e4 */
            ii(0x1017_93ee, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_93f0, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1017_93f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_93f4, 1); popd(edi);                              /* pop edi */
            ii(0x1017_93f5, 1); popd(esi);                              /* pop esi */
            ii(0x1017_93f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_93f7, 1); retd(); return;                         /* ret */
        }
    }
}
