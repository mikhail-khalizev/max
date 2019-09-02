using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_346f-386d1b14")]
        public void Method_1010_346f()
        {
            ii(0x1010_346f, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_3474, 5); call(Definitions.sys_check_available_stack_size, 0x6_28d9); /* call 0x10165d52 */
            ii(0x1010_3479, 1); push(ecx);                              /* push ecx */
            ii(0x1010_347a, 1); push(esi);                              /* push esi */
            ii(0x1010_347b, 1); push(edi);                              /* push edi */
            ii(0x1010_347c, 1); push(ebp);                              /* push ebp */
            ii(0x1010_347d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_347f, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_3485, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_3488, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1010_348b, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1010_348e, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_3492, 2); if(jnz(0x1010_34ad, 0x19)) goto l_0x1010_34ad; /* jnz 0x101034ad */
            ii(0x1010_3494, 5); mov(ecx, 0xce);                         /* mov ecx, 0xce */
            ii(0x1010_3499, 5); mov(ebx, StringDefinitions.HashCpp4);   /* mov ebx, 0x101a315e */
            ii(0x1010_349e, 5); mov(edx, StringDefinitions.AttemptedToAddNullUnitToMapHashTable); /* mov edx, 0x101a3167 */
            ii(0x1010_34a3, 5); mov(eax, StringDefinitions.UnitNotEqual04); /* mov eax, 0x101a3195 */
            ii(0x1010_34a8, 5); call(0x100f_07d4, -0x1_2cd9);           /* call 0x100f07d4 */
        l_0x1010_34ad:
            ii(0x1010_34ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_34b0, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1010_34b4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_34b7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_34ba, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1010_34be, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_34c1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_34c3, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_34c6, 1); push(eax);                              /* push eax */
            ii(0x1010_34c7, 4); movsx(ecx, memw[ss, ebp - 0x14]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x1010_34cb, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1010_34cf, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_34d2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_34d5, 5); call(0x1010_330b, -0x1cf);              /* call 0x1010330b */
            ii(0x1010_34da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_34dd, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1010_34e1, 2); if(jz(0x1010_353a, 0x57)) goto l_0x1010_353a; /* jz 0x1010353a */
            ii(0x1010_34e3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_34e5, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_34e8, 1); push(eax);                              /* push eax */
            ii(0x1010_34e9, 4); movsx(ecx, memw[ss, ebp - 0x14]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x1010_34ed, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_34f0, 1); inc(eax);                               /* inc eax */
            ii(0x1010_34f1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_34f4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_34f7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_34fa, 5); call(0x1010_330b, -0x1f4);              /* call 0x1010330b */
            ii(0x1010_34ff, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_3501, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_3504, 1); push(eax);                              /* push eax */
            ii(0x1010_3505, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_3508, 1); inc(eax);                               /* inc eax */
            ii(0x1010_3509, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_350c, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1010_3510, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_3513, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_3516, 5); call(0x1010_330b, -0x210);              /* call 0x1010330b */
            ii(0x1010_351b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_351d, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_3520, 1); push(eax);                              /* push eax */
            ii(0x1010_3521, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_3524, 1); inc(eax);                               /* inc eax */
            ii(0x1010_3525, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_3528, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_352b, 1); inc(eax);                               /* inc eax */
            ii(0x1010_352c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_352f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_3532, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_3535, 5); call(0x1010_330b, -0x22f);              /* call 0x1010330b */
        l_0x1010_353a:
            ii(0x1010_353a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_353c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_353d, 1); pop(edi);                               /* pop edi */
            ii(0x1010_353e, 1); pop(esi);                               /* pop esi */
            ii(0x1010_353f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_3540, 1); ret();                                  /* ret */
        }
    }
}
