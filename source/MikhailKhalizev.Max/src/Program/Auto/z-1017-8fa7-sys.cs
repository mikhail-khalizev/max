using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_8fa7-8d0bf500")]
        public void /* sys */ Method_1017_8fa7()
        {
            ii(0x1017_8fa7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_8fa8, 1); pushd(esi);                             /* push esi */
            ii(0x1017_8fa9, 1); pushd(edi);                             /* push edi */
            ii(0x1017_8faa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_8fab, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_8fae, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_8fb0, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_8fb2, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_8fb4, 3); mov(ah, memb_a32[ds, ebx + 0xc]);       /* mov ah, [ebx+0xc] */
            ii(0x1017_8fb7, 3); mov(edi, memd_a32[ds, ebx + 0xc]);      /* mov edi, [ebx+0xc] */
            ii(0x1017_8fba, 3); and(ah, 0xcf);                          /* and ah, 0xcf */
            ii(0x1017_8fbd, 3); and(edi, 0x30);                         /* and edi, 0x30 */
            ii(0x1017_8fc0, 3); mov(memb_a32[ds, ebx + 0xc], ah);       /* mov [ebx+0xc], ah */
        l_0x1017_8fc3:
            ii(0x1017_8fc3, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_8fc4, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_8fc6, 2); if(jled(0x1017_8fe7, 0x1f)) goto l_0x1017_8fe7; /* jle 0x10178fe7 */
            ii(0x1017_8fc8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_8fca, 5); calld(/* sys */ 0x1017_1f05, -0x70ca);  /* call 0x10171f05 */
            ii(0x1017_8fcf, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1017_8fd2, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_8fd5, 2); if(jzd(0x1017_8fe7, 0x10)) goto l_0x1017_8fe7; /* jz 0x10178fe7 */
            ii(0x1017_8fd7, 3); mov(al, memb_a32[ss, esp]);             /* mov al, [esp] */
            ii(0x1017_8fda, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1017_8fdc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_8fe1, 1); inc(edx);                               /* inc edx */
            ii(0x1017_8fe2, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1017_8fe5, 2); if(jnzd(0x1017_8fc3, -0x24)) goto l_0x1017_8fc3; /* jnz 0x10178fc3 */
        l_0x1017_8fe7:
            ii(0x1017_8fe7, 4); cmp(memd_a32[ss, esp], -0x1 /* 0xff */); /* cmp dword [esp], 0xffffffff */
            ii(0x1017_8feb, 2); if(jnzd(0x1017_8ffb, 0xe)) goto l_0x1017_8ffb; /* jnz 0x10178ffb */
            ii(0x1017_8fed, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1017_8fef, 2); if(jzd(0x1017_8ff7, 0x6)) goto l_0x1017_8ff7; /* jz 0x10178ff7 */
            ii(0x1017_8ff1, 4); test(memb_a32[ds, ebx + 0xc], 0x20);    /* test byte [ebx+0xc], 0x20 */
            ii(0x1017_8ff5, 2); if(jzd(0x1017_8ffb, 0x4)) goto l_0x1017_8ffb; /* jz 0x10178ffb */
        l_0x1017_8ff7:
            ii(0x1017_8ff7, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_8ff9, 2); jmpd(0x1017_8ffe, 0x3); goto l_0x1017_8ffe; /* jmp 0x10178ffe */
        l_0x1017_8ffb:
            ii(0x1017_8ffb, 3); mov(memb_a32[ds, edx], 0);              /* mov byte [edx], 0x0 */
        l_0x1017_8ffe:
            ii(0x1017_8ffe, 3); mov(ebp, memd_a32[ds, ebx + 0xc]);      /* mov ebp, [ebx+0xc] */
            ii(0x1017_9001, 2); or(ebp, edi);                           /* or ebp, edi */
            ii(0x1017_9003, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_9005, 3); mov(memd_a32[ds, ebx + 0xc], ebp);      /* mov [ebx+0xc], ebp */
            ii(0x1017_9008, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_900b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_900c, 1); popd(edi);                              /* pop edi */
            ii(0x1017_900d, 1); popd(esi);                              /* pop esi */
            ii(0x1017_900e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_900f, 1); retd(); return;                         /* ret */
        }
    }
}
