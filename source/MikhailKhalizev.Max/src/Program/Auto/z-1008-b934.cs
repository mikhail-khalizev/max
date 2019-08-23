using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b934-e1d1bcbe")]
        public void Method_1008_b934()
        {
            ii(0x1008_b934, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_b939, 5); calld(Definitions.sys_check_available_stack_size, 0xd_a414); /* call 0x10165d52 */
            ii(0x1008_b93e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b93f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b940, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b941, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b942, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b943, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b945, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b94b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b94e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b951, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b954, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_b956, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_b959, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1008_b95f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_b962, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_b965, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b968, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1008_b96b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_b96d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1008_b96f, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1008_b975, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_b977, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1008_b97a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_b97d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1008_b981, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_b987, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1008_b98d, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1008_b990, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1008_b995, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1008_b999, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1008_b99b, 2); if(jzd(0x1008_b9ab, 0xe)) goto l_0x1008_b9ab; /* jz 0x1008b9ab */
            ii(0x1008_b99d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_b9a0, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1008_b9a5, 4); cmp(ax, 0x8);                           /* cmp ax, 0x8 */
            ii(0x1008_b9a9, 2); if(jged(0x1008_b9ad, 0x2)) goto l_0x1008_b9ad; /* jge 0x1008b9ad */
        l_0x1008_b9ab:
            ii(0x1008_b9ab, 2); jmpd(0x1008_b9b3, 0x6); goto l_0x1008_b9b3; /* jmp 0x1008b9b3 */
        l_0x1008_b9ad:
            ii(0x1008_b9ad, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_b9b1, 2); jmpd(0x1008_b9b7, 0x4); goto l_0x1008_b9b7; /* jmp 0x1008b9b7 */
        l_0x1008_b9b3:
            ii(0x1008_b9b3, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_b9b7:
            ii(0x1008_b9b7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_b9ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b9bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b9bd, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b9be, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b9bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b9c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b9c1, 1); retd();                                 /* ret */
        }
    }
}
