using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_98f4-5038cbb9")]
        public void /* sys */ Method_1016_98f4()
        {
            ii(0x1016_98f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_98f5, 1); pushd(esi);                             /* push esi */
            ii(0x1016_98f6, 1); pushd(edi);                             /* push edi */
            ii(0x1016_98f7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_98f8, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_98fb, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_98fd, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_98ff, 6); mov(edx, memd_a32[ds, 0x101b_ddbc]);    /* mov edx, [0x101bddbc] */
            ii(0x1016_9905, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1016_990a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_990c, 2); if(jnzd(0x1016_9915, 0x7)) goto l_0x1016_9915; /* jnz 0x10169915 */
            ii(0x1016_990e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_9910, 5); jmpd(0x1016_99ad, 0x98); goto l_0x1016_99ad; /* jmp 0x101699ad */
        l_0x1016_9915:
            ii(0x1016_9915, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_9917, 5); calld(/* sys */ 0x1016_7f00, -0x1a1c);  /* call 0x10167f00 */
            ii(0x1016_991c, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_991e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9920, 2); if(jnzd(0x1016_992c, 0xa)) goto l_0x1016_992c; /* jnz 0x1016992c */
            ii(0x1016_9922, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_9924, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_9927, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_9928, 1); popd(edi);                              /* pop edi */
            ii(0x1016_9929, 1); popd(esi);                              /* pop esi */
            ii(0x1016_992a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_992b, 1); retd(); return;                         /* ret */
        l_0x1016_992c:
            ii(0x1016_992c, 4); test(memb_a32[ds, eax + 0x4], 0x1);     /* test byte [eax+0x4], 0x1 */
            ii(0x1016_9930, 6); if(jzd(0x1016_99ab, 0x75)) goto l_0x1016_99ab; /* jz 0x101699ab */
            ii(0x1016_9936, 3); mov(dl, memb_a32[ds, esi + 0x6]);       /* mov dl, [esi+0x6] */
            ii(0x1016_9939, 3); test(dl, 0x2);                          /* test dl, 0x2 */
            ii(0x1016_993c, 2); if(jzd(0x1016_996d, 0x2f)) goto l_0x1016_996d; /* jz 0x1016996d */
            ii(0x1016_993e, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_9940, 2); if(jnzd(0x1016_999b, 0x59)) goto l_0x1016_999b; /* jnz 0x1016999b */
            ii(0x1016_9942, 2); mov(bl, dl);                            /* mov bl, dl */
            ii(0x1016_9944, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9945, 3); and(bl, 0xfd);                          /* and bl, 0xfd */
            ii(0x1016_9948, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_994a, 3); mov(memb_a32[ds, esi + 0x6], bl);       /* mov [esi+0x6], bl */
            ii(0x1016_994d, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9952, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_9956, 3); mov(ebx, memd_a32[ds, esi + 0x30]);     /* mov ebx, [esi+0x30] */
            ii(0x1016_9959, 5); calld(/* sys */ 0x1016_9b90, 0x232);    /* call 0x10169b90 */
            ii(0x1016_995e, 3); mov(ebp, memd_a32[ds, esi + 0x68]);     /* mov ebp, [esi+0x68] */
            ii(0x1016_9961, 3); mov(ebx, memd_a32[ds, esi + 0x24]);     /* mov ebx, [esi+0x24] */
            ii(0x1016_9964, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_9966, 2); if(jzd(0x1016_999b, 0x33)) goto l_0x1016_999b; /* jz 0x1016999b */
            ii(0x1016_9968, 3); dec(memd_a32[ss, ebp + 0x4]);           /* dec dword [ebp+0x4] */
            ii(0x1016_996b, 2); jmpd(0x1016_999b, 0x2e); goto l_0x1016_999b; /* jmp 0x1016999b */
        l_0x1016_996d:
            ii(0x1016_996d, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_996f, 2); if(jzd(0x1016_999b, 0x2a)) goto l_0x1016_999b; /* jz 0x1016999b */
            ii(0x1016_9971, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1016_9973, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9975, 3); or(dh, 0x2);                            /* or dh, 0x2 */
            ii(0x1016_9978, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_997d, 3); mov(memb_a32[ds, esi + 0x6], dh);       /* mov [esi+0x6], dh */
            ii(0x1016_9980, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9982, 3); mov(ebx, memd_a32[ds, esi + 0x34]);     /* mov ebx, [esi+0x34] */
            ii(0x1016_9985, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_9989, 5); calld(/* sys */ 0x1016_9b90, 0x202);    /* call 0x10169b90 */
            ii(0x1016_998e, 3); mov(ecx, memd_a32[ds, esi + 0x68]);     /* mov ecx, [esi+0x68] */
            ii(0x1016_9991, 3); mov(ebx, memd_a32[ds, esi + 0x20]);     /* mov ebx, [esi+0x20] */
            ii(0x1016_9994, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_9996, 2); if(jzd(0x1016_999b, 0x3)) goto l_0x1016_999b; /* jz 0x1016999b */
            ii(0x1016_9998, 3); inc(memd_a32[ds, ecx + 0x4]);           /* inc dword [ecx+0x4] */
        l_0x1016_999b:
            ii(0x1016_999b, 3); cmp(ebx, -0x1 /* 0xff */);              /* cmp ebx, 0xffffffff */
            ii(0x1016_999e, 2); if(jzd(0x1016_99ab, 0xb)) goto l_0x1016_99ab; /* jz 0x101699ab */
            ii(0x1016_99a0, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_99a2, 2); if(jzd(0x1016_99ab, 0x7)) goto l_0x1016_99ab; /* jz 0x101699ab */
            ii(0x1016_99a4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_99a6, 5); calld(/* sys */ 0x1016_b280, 0x18d5);   /* call 0x1016b280 */
        l_0x1016_99ab:
            ii(0x1016_99ab, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_99ad:
            ii(0x1016_99ad, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_99b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_99b1, 1); popd(edi);                              /* pop edi */
            ii(0x1016_99b2, 1); popd(esi);                              /* pop esi */
            ii(0x1016_99b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_99b4, 1); retd();                                 /* ret */
        }
    }
}
