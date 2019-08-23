using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a450-94678bee")]
        public void /* sys */ Method_1017_a450()
        {
            ii(0x1017_a450, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_a451, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_a453, 1); pushd(esi);                             /* push esi */
            ii(0x1017_a454, 1); pushd(edi);                             /* push edi */
            ii(0x1017_a455, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_a458, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1017_a45b, 5); mov(memb_a32[ds, 0x1020_9dd4], al);     /* mov [0x10209dd4], al */
            ii(0x1017_a460, 7); lea(eax, eax * 8 + 0);                  /* lea eax, [eax*8] */
            ii(0x1017_a467, 5); mov(memd_a32[ds, 0x1020_9cd0], eax);    /* mov [0x10209cd0], eax */
            ii(0x1017_a46c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1017_a46f, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1017_a472, 3); mov(dl, memb_a32[ss, ebp - 0xc]);       /* mov dl, [ebp-0xc] */
            ii(0x1017_a475, 6); mov(memb_a32[ds, 0x1020_9dd2], bl);     /* mov [0x10209dd2], bl */
            ii(0x1017_a47b, 6); mov(memb_a32[ds, 0x1020_9dd3], dl);     /* mov [0x10209dd3], dl */
            ii(0x1017_a481, 7); lea(eax, eax * 8 + 0);                  /* lea eax, [eax*8] */
            ii(0x1017_a488, 6); mov(edx, memd_a32[ds, 0x101b_e200]);    /* mov edx, [0x101be200] */
            ii(0x1017_a48e, 5); mov(memd_a32[ds, 0x1020_9cf0], eax);    /* mov [0x10209cf0], eax */
            ii(0x1017_a493, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_a495, 2); if(jzd(0x1017_a4a1, 0xa)) goto l_0x1017_a4a1; /* jz 0x1017a4a1 */
            ii(0x1017_a497, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_a499, 2); shr(esi, 0x1);                          /* shr esi, 1 */
            ii(0x1017_a49b, 6); mov(memd_a32[ds, 0x1020_9cf0], esi);    /* mov [0x10209cf0], esi */
        l_0x1017_a4a1:
            ii(0x1017_a4a1, 5); mov(eax, memd_a32[ds, 0x1020_9cd0]);    /* mov eax, [0x10209cd0] */
            ii(0x1017_a4a6, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1017_a4a9, 3); sub(eax, 0x8);                          /* sub eax, 0x8 */
            ii(0x1017_a4ac, 6); mov(memd_a32[ds, 0x1020_9ccc], ecx);    /* mov [0x10209ccc], ecx */
            ii(0x1017_a4b2, 5); mov(memd_a32[ds, 0x1020_9ce8], eax);    /* mov [0x10209ce8], eax */
            ii(0x1017_a4b7, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_a4b9, 2); if(jzd(0x1017_a4d0, 0x15)) goto l_0x1017_a4d0; /* jz 0x1017a4d0 */
            ii(0x1017_a4bb, 6); mov(edi, memd_a32[ds, 0x1020_9cd0]);    /* mov edi, [0x10209cd0] */
            ii(0x1017_a4c1, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1017_a4c3, 2); add(edi, edi);                          /* add edi, edi */
            ii(0x1017_a4c5, 5); mov(memd_a32[ds, 0x1020_9ce8], eax);    /* mov [0x10209ce8], eax */
            ii(0x1017_a4ca, 6); mov(memd_a32[ds, 0x1020_9cd0], edi);    /* mov [0x10209cd0], edi */
        l_0x1017_a4d0:
            ii(0x1017_a4d0, 5); mov(eax, memd_a32[ds, 0x1020_9cd0]);    /* mov eax, [0x10209cd0] */
            ii(0x1017_a4d5, 7); lea(ecx, ebx * 8 + 0);                  /* lea ecx, [ebx*8] */
            ii(0x1017_a4dc, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1017_a4df, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_a4e1, 7); lea(ebx, ebx * 8 + 0);                  /* lea ebx, [ebx*8] */
            ii(0x1017_a4e8, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1017_a4ea, 5); mov(eax, memd_a32[ds, 0x1020_9cd0]);    /* mov eax, [0x10209cd0] */
            ii(0x1017_a4ef, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1017_a4f2, 6); mov(edx, memd_a32[ds, 0x1020_9cf0]);    /* mov edx, [0x10209cf0] */
            ii(0x1017_a4f8, 6); mov(memd_a32[ds, 0x1020_9cec], ebx);    /* mov [0x10209cec], ebx */
            ii(0x1017_a4fe, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_a500, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x1017_a503, 5); mov(eax, 0x1020_9a50);                  /* mov eax, 0x10209a50 */
            ii(0x1017_a508, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_a50a, 6); mov(memd_a32[ds, 0x1020_9cc4], ecx);    /* mov [0x10209cc4], ecx */
            ii(0x1017_a510, 5); calld(/* sys */ 0x1017_95d0, -0xf45);   /* call 0x101795d0 */
            ii(0x1017_a515, 5); mov(memd_a32[ds, 0x1020_9cc8], eax);    /* mov [0x10209cc8], eax */
            ii(0x1017_a51a, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_a51c, 5); mov(eax, 0x1020_9a60);                  /* mov eax, 0x10209a60 */
            ii(0x1017_a521, 5); calld(/* sys */ 0x1017_95d0, -0xf56);   /* call 0x101795d0 */
            ii(0x1017_a526, 6); mov(ecx, memd_a32[ds, 0x1020_9cc8]);    /* mov ecx, [0x10209cc8] */
            ii(0x1017_a52c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_a52e, 5); mov(memd_a32[ds, 0x1020_9cd8], eax);    /* mov [0x10209cd8], eax */
            ii(0x1017_a533, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_a535, 2); if(jzd(0x1017_a53b, 0x4)) goto l_0x1017_a53b; /* jz 0x1017a53b */
            ii(0x1017_a537, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_a539, 2); if(jnzd(0x1017_a53f, 0x4)) goto l_0x1017_a53f; /* jnz 0x1017a53f */
        l_0x1017_a53b:
            ii(0x1017_a53b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_a53d, 2); jmpd(0x1017_a549, 0xa); goto l_0x1017_a549; /* jmp 0x1017a549 */
        l_0x1017_a53f:
            ii(0x1017_a53f, 5); calld(/* sys */ 0x1018_e803, 0x1_42bf); /* call 0x1018e803 */
            ii(0x1017_a544, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1017_a549:
            ii(0x1017_a549, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_a54c, 1); popd(edi);                              /* pop edi */
            ii(0x1017_a54d, 1); popd(esi);                              /* pop esi */
            ii(0x1017_a54e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_a54f, 1); retd();                                 /* ret */
        }
    }
}
