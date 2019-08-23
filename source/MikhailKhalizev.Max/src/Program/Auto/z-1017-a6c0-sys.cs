using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a6c0-b3c5150f")]
        public void /* sys */ Method_1017_a6c0()
        {
            ii(0x1017_a6c0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_a6c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_a6c3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a6c4, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a6c5, 1); pushd(edi);                             /* push edi */
            ii(0x1017_a6c6, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_a6c8, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_a6ca, 5); mov(eax, memd_a32[ds, 0x1020_9cd0]);    /* mov eax, [0x10209cd0] */
            ii(0x1017_a6cf, 6); mov(edi, memd_a32[ds, 0x101b_e204]);    /* mov edi, [0x101be204] */
            ii(0x1017_a6d5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_a6d7, 7); lea(eax, eax * 4 + 0);                  /* lea eax, [eax*4] */
            ii(0x1017_a6de, 2); div(edi);                               /* div edi */
            ii(0x1017_a6e0, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x1017_a6e3, 2); and(al, 0xf0);                          /* and al, 0xf0 */
            ii(0x1017_a6e5, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1017_a6e8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_a6ea, 3); shr(edx, 0x2);                          /* shr edx, 0x2 */
            ii(0x1017_a6ed, 3); imul(edi, edx);                         /* imul edi, edx */
            ii(0x1017_a6f0, 6); mov(edx, memd_a32[ds, 0x1020_9cd0]);    /* mov edx, [0x10209cd0] */
            ii(0x1017_a6f6, 2); sub(edx, edi);                          /* sub edx, edi */
            ii(0x1017_a6f8, 6); mov(memd_a32[ds, 0x1020_9dc8], edx);    /* mov [0x10209dc8], edx */
            ii(0x1017_a6fe, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_a700, 2); if(jged(0x1017_a723, 0x21)) goto l_0x1017_a723; /* jge 0x1017a723 */
            ii(0x1017_a702, 7); cmp(memd_a32[ds, 0x1020_9ccc], 0);      /* cmp dword [0x10209ccc], 0x0 */
            ii(0x1017_a709, 2); if(jzd(0x1017_a719, 0xe)) goto l_0x1017_a719; /* jz 0x1017a719 */
            ii(0x1017_a70b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_a70d, 6); mov(ecx, memd_a32[ds, 0x1020_9cb4]);    /* mov ecx, [0x10209cb4] */
            ii(0x1017_a713, 2); shr(edx, 0x1);                          /* shr edx, 1 */
            ii(0x1017_a715, 2); sub(ecx, edx);                          /* sub ecx, edx */
            ii(0x1017_a717, 2); jmpd(0x1017_a721, 0x8); goto l_0x1017_a721; /* jmp 0x1017a721 */
        l_0x1017_a719:
            ii(0x1017_a719, 6); mov(ecx, memd_a32[ds, 0x1020_9cb4]);    /* mov ecx, [0x10209cb4] */
            ii(0x1017_a71f, 2); sub(ecx, eax);                          /* sub ecx, eax */
        l_0x1017_a721:
            ii(0x1017_a721, 2); shr(ecx, 0x1);                          /* shr ecx, 1 */
        l_0x1017_a723:
            ii(0x1017_a723, 7); cmp(memd_a32[ds, 0x1020_9ccc], 0);      /* cmp dword [0x10209ccc], 0x0 */
            ii(0x1017_a72a, 2); if(jzd(0x1017_a72e, 0x2)) goto l_0x1017_a72e; /* jz 0x1017a72e */
            ii(0x1017_a72c, 2); add(ecx, ecx);                          /* add ecx, ecx */
        l_0x1017_a72e:
            ii(0x1017_a72e, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_a730, 2); if(jged(0x1017_a75b, 0x29)) goto l_0x1017_a75b; /* jge 0x1017a75b */
            ii(0x1017_a732, 7); test(memb_a32[ds, 0x101b_e200], 0x4);   /* test byte [0x101be200], 0x4 */
            ii(0x1017_a739, 2); if(jzd(0x1017_a74d, 0x12)) goto l_0x1017_a74d; /* jz 0x1017a74d */
            ii(0x1017_a73b, 6); mov(edx, memd_a32[ds, 0x1020_9cf0]);    /* mov edx, [0x10209cf0] */
            ii(0x1017_a741, 6); mov(esi, memd_a32[ds, 0x1020_9cbc]);    /* mov esi, [0x10209cbc] */
            ii(0x1017_a747, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1017_a749, 2); sub(esi, edx);                          /* sub esi, edx */
            ii(0x1017_a74b, 2); jmpd(0x1017_a759, 0xc); goto l_0x1017_a759; /* jmp 0x1017a759 */
        l_0x1017_a74d:
            ii(0x1017_a74d, 6); mov(esi, memd_a32[ds, 0x1020_9cbc]);    /* mov esi, [0x10209cbc] */
            ii(0x1017_a753, 6); sub(esi, memd_a32[ds, 0x1020_9cf0]);    /* sub esi, [0x10209cf0] */
        l_0x1017_a759:
            ii(0x1017_a759, 2); shr(esi, 0x1);                          /* shr esi, 1 */
        l_0x1017_a75b:
            ii(0x1017_a75b, 7); xor(memb_a32[ds, 0x101b_e208], 0x1);    /* xor byte [0x101be208], 0x1 */
            ii(0x1017_a762, 6); mov(edx, memd_a32[ds, 0x101b_e208]);    /* mov edx, [0x101be208] */
            ii(0x1017_a768, 3); and(cl, 0xfc);                          /* and cl, 0xfc */
            ii(0x1017_a76b, 7); mov(edi, memd_a32[ds, edx * 4 + 0x101b_e20c]); /* mov edi, [edx*4+0x101be20c] */
            ii(0x1017_a772, 6); mov(dl, memb_a32[ds, 0x101b_e200]);     /* mov dl, [0x101be200] */
            ii(0x1017_a778, 2); add(esi, edi);                          /* add esi, edi */
            ii(0x1017_a77a, 3); test(dl, 0x4);                          /* test dl, 0x4 */
            ii(0x1017_a77d, 2); if(jzd(0x1017_a781, 0x2)) goto l_0x1017_a781; /* jz 0x1017a781 */
            ii(0x1017_a77f, 2); sar(esi, 0x1);                          /* sar esi, 1 */
        l_0x1017_a781:
            ii(0x1017_a781, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_a783, 2); if(jzd(0x1017_a7c2, 0x3d)) goto l_0x1017_a7c2; /* jz 0x1017a7c2 */
            ii(0x1017_a785, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_a786, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a787, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a788, 6); mov(ebx, memd_a32[ds, 0x1020_9cd4]);    /* mov ebx, [0x10209cd4] */
            ii(0x1017_a78e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_a78f, 6); mov(ecx, memd_a32[ds, 0x1020_9cdc]);    /* mov ecx, [0x10209cdc] */
            ii(0x1017_a795, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a796, 6); mov(esi, memd_a32[ds, 0x1020_9ce4]);    /* mov esi, [0x10209ce4] */
            ii(0x1017_a79c, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a79d, 6); mov(edi, memd_a32[ds, 0x1020_9ce0]);    /* mov edi, [0x10209ce0] */
            ii(0x1017_a7a3, 1); pushd(edi);                             /* push edi */
            ii(0x1017_a7a4, 5); mov(eax, memd_a32[ds, 0x1020_9cf0]);    /* mov eax, [0x10209cf0] */
            ii(0x1017_a7a9, 1); pushd(eax);                             /* push eax */
            ii(0x1017_a7aa, 6); mov(edx, memd_a32[ds, 0x1020_9cd0]);    /* mov edx, [0x10209cd0] */
            ii(0x1017_a7b0, 1); pushd(edx);                             /* push edx */
            ii(0x1017_a7b1, 6); mov(ebx, memd_a32[ds, 0x1020_9cc8]);    /* mov ebx, [0x10209cc8] */
            ii(0x1017_a7b7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_a7b8, 5); calld(/* sys */ 0x1019_33cd, 0x1_8c10); /* call 0x101933cd */
            ii(0x1017_a7bd, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1017_a7c0, 2); jmpd(0x1017_a82e, 0x6c); goto l_0x1017_a82e; /* jmp 0x1017a82e */
        l_0x1017_a7c2:
            ii(0x1017_a7c2, 7); cmp(memd_a32[ds, 0x101b_e204], 0x4);    /* cmp dword [0x101be204], 0x4 */
            ii(0x1017_a7c9, 2); if(jzd(0x1017_a7f3, 0x28)) goto l_0x1017_a7f3; /* jz 0x1017a7f3 */
            ii(0x1017_a7cb, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a7cc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a7cd, 6); mov(ecx, memd_a32[ds, 0x1020_9cd4]);    /* mov ecx, [0x10209cd4] */
            ii(0x1017_a7d3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a7d4, 1); pushd(eax);                             /* push eax */
            ii(0x1017_a7d5, 6); mov(esi, memd_a32[ds, 0x1020_9ce4]);    /* mov esi, [0x10209ce4] */
            ii(0x1017_a7db, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a7dc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_a7dd, 6); mov(edi, memd_a32[ds, 0x1020_9cf0]);    /* mov edi, [0x10209cf0] */
            ii(0x1017_a7e3, 1); pushd(edi);                             /* push edi */
            ii(0x1017_a7e4, 5); mov(eax, memd_a32[ds, 0x1020_9cd0]);    /* mov eax, [0x10209cd0] */
            ii(0x1017_a7e9, 1); pushd(eax);                             /* push eax */
            ii(0x1017_a7ea, 6); mov(edx, memd_a32[ds, 0x1020_9cc8]);    /* mov edx, [0x10209cc8] */
            ii(0x1017_a7f0, 1); pushd(edx);                             /* push edx */
            ii(0x1017_a7f1, 2); jmpd(0x1017_a825, 0x32); goto l_0x1017_a825; /* jmp 0x1017a825 */
        l_0x1017_a7f3:
            ii(0x1017_a7f3, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a7f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a7f5, 6); mov(ebx, memd_a32[ds, 0x1020_9cd4]);    /* mov ebx, [0x10209cd4] */
            ii(0x1017_a7fb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_a7fc, 6); mov(ecx, memd_a32[ds, 0x1020_9cdc]);    /* mov ecx, [0x10209cdc] */
            ii(0x1017_a802, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_a803, 6); mov(esi, memd_a32[ds, 0x1020_9ce4]);    /* mov esi, [0x10209ce4] */
            ii(0x1017_a809, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a80a, 6); mov(edi, memd_a32[ds, 0x1020_9ce0]);    /* mov edi, [0x10209ce0] */
            ii(0x1017_a810, 1); pushd(edi);                             /* push edi */
            ii(0x1017_a811, 5); mov(eax, memd_a32[ds, 0x1020_9cf0]);    /* mov eax, [0x10209cf0] */
            ii(0x1017_a816, 1); pushd(eax);                             /* push eax */
            ii(0x1017_a817, 6); mov(edx, memd_a32[ds, 0x1020_9cd0]);    /* mov edx, [0x10209cd0] */
            ii(0x1017_a81d, 1); pushd(edx);                             /* push edx */
            ii(0x1017_a81e, 6); mov(ebx, memd_a32[ds, 0x1020_9cc8]);    /* mov ebx, [0x10209cc8] */
            ii(0x1017_a824, 1); pushd(ebx);                             /* push ebx */
        l_0x1017_a825:
            ii(0x1017_a825, 6); calld_abs(memd_a32[ds, 0x101b_e444]);   /* call dword [0x101be444] */ /* Вызов '0x1017_a850'. */
            ii(0x1017_a82b, 3); add(esp, 0x24);                         /* add esp, 0x24 */
        l_0x1017_a82e:
            ii(0x1017_a82e, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1017_a831, 1); popd(edi);                              /* pop edi */
            ii(0x1017_a832, 1); popd(esi);                              /* pop esi */
            ii(0x1017_a833, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_a834, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_a835, 1); retd();                                 /* ret */
        }
    }
}
