using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_cda1-2fdc748c")]
        public void Method_1019_cda1()
        {
            ii(0x1019_cda1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_cda2, 1); pushd(edi);                             /* push edi */
            ii(0x1019_cda3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_cda4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_cda5, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1019_cda7, 3); mov(ecx, memd_a32[ss, ebp + 0]);        /* mov ecx, [ebp] */
            ii(0x1019_cdaa, 3); mov(eax, memd_a32[ss, ebp + 0x4]);      /* mov eax, [ebp+0x4] */
            ii(0x1019_cdad, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1019_cdaf, 2); add(ebp, ebx);                          /* add ebp, ebx */
            ii(0x1019_cdb1, 4); mov(memb_a32[ss, ebp + 0], 0);          /* mov byte [ebp], 0x0 */
            ii(0x1019_cdb5, 1); pushd(eax);                             /* push eax */
        l_0x1019_cdb6:
            ii(0x1019_cdb6, 1); popd(eax);                              /* pop eax */
            ii(0x1019_cdb7, 5); mov(edi, 0x2710);                       /* mov edi, 0x2710 */
            ii(0x1019_cdbc, 2); sub(edx, edx);                          /* sub edx, edx */
            ii(0x1019_cdbe, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1019_cdc0, 2); if(jnzd(0x1019_cdc9, 0x7)) goto l_0x1019_cdc9; /* jnz 0x1019cdc9 */
            ii(0x1019_cdc2, 2); or(ecx, ecx);                           /* or ecx, ecx */
            ii(0x1019_cdc4, 2); if(jnzd(0x1019_cdcb, 0x5)) goto l_0x1019_cdcb; /* jnz 0x1019cdcb */
            ii(0x1019_cdc6, 1); pushd(eax);                             /* push eax */
            ii(0x1019_cdc7, 2); jmpd(0x1019_cde1, 0x18); goto l_0x1019_cde1; /* jmp 0x1019cde1 */
        l_0x1019_cdc9:
            ii(0x1019_cdc9, 2); div(edi);                               /* div edi */
        l_0x1019_cdcb:
            ii(0x1019_cdcb, 1); xchg(ecx, eax);                         /* xchg ecx, eax */
            ii(0x1019_cdcc, 2); div(edi);                               /* div edi */
            ii(0x1019_cdce, 1); xchg(ecx, eax);                         /* xchg ecx, eax */
            ii(0x1019_cdcf, 1); pushd(eax);                             /* push eax */
            ii(0x1019_cdd0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_cdd2, 2); mov(dl, 0x64);                          /* mov dl, 0x64 */
            ii(0x1019_cdd4, 2); div(dl);                                /* div dl */
            ii(0x1019_cdd6, 2); mov(dl, ah);                            /* mov dl, ah */
            ii(0x1019_cdd8, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1019_cdda, 2); aam(0xa);                               /* aam 0xa */
            ii(0x1019_cddc, 1); xchg(edx, eax);                         /* xchg edx, eax */
            ii(0x1019_cddd, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1019_cddf, 2); aam(0xa);                               /* aam 0xa */
        l_0x1019_cde1:
            ii(0x1019_cde1, 4); add(ax, 0x3030);                        /* add ax, 0x3030 */
            ii(0x1019_cde5, 5); add(dx, 0x3030);                        /* add dx, 0x3030 */
            ii(0x1019_cdea, 3); sub(ebp, 0x4);                          /* sub ebp, 0x4 */
            ii(0x1019_cded, 3); mov(memb_a32[ss, ebp + 0x3], al);       /* mov [ebp+0x3], al */
            ii(0x1019_cdf0, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_cdf1, 2); if(jzd(0x1019_ce05, 0x12)) goto l_0x1019_ce05; /* jz 0x1019ce05 */
            ii(0x1019_cdf3, 3); mov(memb_a32[ss, ebp + 0x2], ah);       /* mov [ebp+0x2], ah */
            ii(0x1019_cdf6, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_cdf7, 2); if(jzd(0x1019_ce05, 0xc)) goto l_0x1019_ce05; /* jz 0x1019ce05 */
            ii(0x1019_cdf9, 3); mov(memb_a32[ss, ebp + 0x1], dl);       /* mov [ebp+0x1], dl */
            ii(0x1019_cdfc, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_cdfd, 2); if(jzd(0x1019_ce05, 0x6)) goto l_0x1019_ce05; /* jz 0x1019ce05 */
            ii(0x1019_cdff, 3); mov(memb_a32[ss, ebp + 0], dh);         /* mov [ebp], dh */
            ii(0x1019_ce02, 1); dec(ebx);                               /* dec ebx */
            ii(0x1019_ce03, 2); if(jnzd(0x1019_cdb6, -0x4f)) goto l_0x1019_cdb6; /* jnz 0x1019cdb6 */
        l_0x1019_ce05:
            ii(0x1019_ce05, 1); popd(eax);                              /* pop eax */
            ii(0x1019_ce06, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_ce07, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_ce08, 1); popd(edi);                              /* pop edi */
            ii(0x1019_ce09, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_ce0a, 1); retd();                                 /* ret */
        }
    }
}
