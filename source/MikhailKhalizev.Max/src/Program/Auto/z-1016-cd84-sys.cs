using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_cd84-82ac05dc")]
        public void /* sys */ Method_1016_cd84()
        {
            ii(0x1016_cd84, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_cd85, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_cd86, 1); pushd(edx);                             /* push edx */
            ii(0x1016_cd87, 1); pushd(esi);                             /* push esi */
            ii(0x1016_cd88, 1); pushd(edi);                             /* push edi */
            ii(0x1016_cd89, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_cd8a, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_cd8d, 4); mov(memb_a32[ss, esp + 0xc], al);       /* mov [esp+0xc], al */
            ii(0x1016_cd91, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_cd93, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_cd95:
            ii(0x1016_cd95, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_cd97, 4); mov(bl, memb_a32[ss, esp + 0xc]);       /* mov bl, [esp+0xc] */
            ii(0x1016_cd9b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_cd9d, 5); calld(/* sys */ 0x1016_cae8, -0x2ba);   /* call 0x1016cae8 */
            ii(0x1016_cda2, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_cda4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_cda6, 5); calld(/* sys */ 0x1016_cae8, -0x2c3);   /* call 0x1016cae8 */
            ii(0x1016_cdab, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_cdad, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_cdaf, 6); and(edi, 0x7c00);                       /* and edi, 0x7c00 */
            ii(0x1016_cdb5, 5); calld(/* sys */ 0x1016_cae8, -0x2d2);   /* call 0x1016cae8 */
            ii(0x1016_cdba, 3); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1016_cdbd, 3); sar(edi, 0xa);                          /* sar edi, 0xa */
            ii(0x1016_cdc0, 4); mov(memd_a32[ss, esp + 0x8], eax);      /* mov [esp+0x8], eax */
            ii(0x1016_cdc4, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_cdc6, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_cdc9, 4); mov(ebp, memd_a32[ss, esp + 0x8]);      /* mov ebp, [esp+0x8] */
            ii(0x1016_cdcd, 3); imul(ebp, edx);                         /* imul ebp, edx */
            ii(0x1016_cdd0, 6); and(esi, 0x3e0);                        /* and esi, 0x3e0 */
            ii(0x1016_cdd6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_cdd9, 3); sar(esi, 0x5);                          /* sar esi, 0x5 */
            ii(0x1016_cddc, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_cde0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_cde2, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_cde5, 3); sar(ebp, 0x10);                         /* sar ebp, 0x10 */
            ii(0x1016_cde8, 3); mov(memd_a32[ss, esp], ebp);            /* mov [esp], ebp */
            ii(0x1016_cdeb, 4); mov(ebp, memd_a32[ss, esp + 0x4]);      /* mov ebp, [esp+0x4] */
            ii(0x1016_cdef, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_cdf2, 3); shl(ebp, 0xa);                          /* shl ebp, 0xa */
            ii(0x1016_cdf5, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x1016_cdf8, 2); or(eax, ebp);                           /* or eax, ebp */
            ii(0x1016_cdfa, 3); or(eax, memd_a32[ss, esp]);             /* or eax, [esp] */
            ii(0x1016_cdfd, 6); mov(al, memb_a32[ds, eax + 0x1020_0520]); /* mov al, [eax+0x10200520] */
            ii(0x1016_ce03, 5); mov(ebp, 0x1f);                         /* mov ebp, 0x1f */
            ii(0x1016_ce08, 4); sub(ebp, memd_a32[ss, esp + 0x8]);      /* sub ebp, [esp+0x8] */
            ii(0x1016_ce0c, 3); imul(ebp, edx);                         /* imul ebp, edx */
            ii(0x1016_ce0f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_ce14, 3); shl(ebx, 0x8);                          /* shl ebx, 0x8 */
            ii(0x1016_ce17, 7); mov(memb_a32[ds, ecx + ebx + 0x101e_0520], al); /* mov [ecx+ebx+0x101e0520], al */
            ii(0x1016_ce1e, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1016_ce23, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_ce25, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_ce28, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_ce2b, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_ce2f, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1016_ce34, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_ce36, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_ce39, 3); sar(ebp, 0x10);                         /* sar ebp, 0x10 */
            ii(0x1016_ce3c, 3); mov(memd_a32[ss, esp], ebp);            /* mov [esp], ebp */
            ii(0x1016_ce3f, 4); mov(ebp, memd_a32[ss, esp + 0x4]);      /* mov ebp, [esp+0x4] */
            ii(0x1016_ce43, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_ce46, 2); add(edi, ebp);                          /* add edi, ebp */
            ii(0x1016_ce48, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_ce4a, 3); shl(edi, 0xa);                          /* shl edi, 0xa */
            ii(0x1016_ce4d, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x1016_ce50, 3); mov(esi, memd_a32[ss, esp]);            /* mov esi, [esp] */
            ii(0x1016_ce53, 2); or(edi, eax);                           /* or edi, eax */
            ii(0x1016_ce55, 4); mov(eax, memd_a32[ss, esp + 0x8]);      /* mov eax, [esp+0x8] */
            ii(0x1016_ce59, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_ce5b, 2); or(eax, edi);                           /* or eax, edi */
            ii(0x1016_ce5d, 6); mov(al, memb_a32[ds, eax + 0x1020_0520]); /* mov al, [eax+0x10200520] */
            ii(0x1016_ce63, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_ce68, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_ce69, 6); add(edx, 0x200);                        /* add edx, 0x200 */
            ii(0x1016_ce6f, 7); mov(memb_a32[ds, ecx + ebx + 0x101e_059f], al); /* mov [ecx+ebx+0x101e059f], al */
            ii(0x1016_ce76, 6); cmp(ecx, 0x80);                         /* cmp ecx, 0x80 */
            ii(0x1016_ce7c, 6); if(jld(0x1016_cd95, -0xed)) goto l_0x1016_cd95; /* jl 0x1016cd95 */
            ii(0x1016_ce82, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_ce85, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_ce86, 1); popd(edi);                              /* pop edi */
            ii(0x1016_ce87, 1); popd(esi);                              /* pop esi */
            ii(0x1016_ce88, 1); popd(edx);                              /* pop edx */
            ii(0x1016_ce89, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_ce8a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_ce8b, 1); retd(); return;                         /* ret */
        }
    }
}
