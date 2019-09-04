using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f437-7dec1e6b")]
        public void Method_1007_f437()
        {
            ii(0x1007_f437, 5); push(0x38);                             /* push 0x38 */
            ii(0x1007_f43c, 5); call(Definitions.sys_check_available_stack_size, 0xe_6911); /* call 0x10165d52 */
            ii(0x1007_f441, 1); push(ebx);                              /* push ebx */
            ii(0x1007_f442, 1); push(ecx);                              /* push ecx */
            ii(0x1007_f443, 1); push(esi);                              /* push esi */
            ii(0x1007_f444, 1); push(edi);                              /* push edi */
            ii(0x1007_f445, 1); push(ebp);                              /* push ebp */
            ii(0x1007_f446, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f448, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_f44e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_f451, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_f454, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f456, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f459, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f45c, 5); call(0x1013_ad11, 0xb_b8b0);            /* call 0x1013ad11 */
            ii(0x1007_f461, 2); test(al, al);                           /* test al, al */
            ii(0x1007_f463, 2); if(jnz(0x1007_f479, 0x14)) goto l_0x1007_f479; /* jnz 0x1007f479 */
            ii(0x1007_f465, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f468, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f46b, 5); call(0x1008_a228, 0xadb8);              /* call 0x1008a228 */
            ii(0x1007_f470, 5); call(0x1008_a370, 0xaefb);              /* call 0x1008a370 */
            ii(0x1007_f475, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_f477, 2); if(jnz(0x1007_f47b, 2)) goto l_0x1007_f47b; /* jnz 0x1007f47b */
        l_0x1007_f479:
            ii(0x1007_f479, 2); jmp(0x1007_f497, 0x1c); goto l_0x1007_f497; /* jmp 0x1007f497 */
        l_0x1007_f47b:
            ii(0x1007_f47b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f47e, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f481, 5); call(0x1008_a228, 0xada2);              /* call 0x1008a228 */
            ii(0x1007_f486, 5); call(0x1008_a370, 0xaee5);              /* call 0x1008a370 */
            ii(0x1007_f48b, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x1007_f48e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_f493, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_f495, 2); if(jnz(0x1007_f4a6, 0xf)) goto l_0x1007_f4a6; /* jnz 0x1007f4a6 */
        l_0x1007_f497:
            ii(0x1007_f497, 5); mov(edx, StringDefinitions.CompletedFrontalAttack); /* mov edx, 0x101a01cb */
            ii(0x1007_f49c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f49f, 5); call(Definitions.sys_strcpy, 0xe_6a2b); /* call 0x10165ecf */
            ii(0x1007_f4a4, 2); jmp(0x1007_f4fd, 0x57); goto l_0x1007_f4fd; /* jmp 0x1007f4fd */
        l_0x1007_f4a6:
            ii(0x1007_f4a6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f4a9, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f4ac, 5); call(0x1008_a228, 0xad77);              /* call 0x1008a228 */
            ii(0x1007_f4b1, 5); call(0x100b_8eda, 0x3_9a24);            /* call 0x100b8eda */
            ii(0x1007_f4b6, 1); cwde();                                 /* cwde */
            ii(0x1007_f4b7, 1); inc(eax);                               /* inc eax */
            ii(0x1007_f4b8, 1); push(eax);                              /* push eax */
            ii(0x1007_f4b9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f4bc, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f4bf, 5); call(0x1008_a228, 0xad64);              /* call 0x1008a228 */
            ii(0x1007_f4c4, 5); call(0x100b_8ea1, 0x3_99d8);            /* call 0x100b8ea1 */
            ii(0x1007_f4c9, 1); cwde();                                 /* cwde */
            ii(0x1007_f4ca, 1); inc(eax);                               /* inc eax */
            ii(0x1007_f4cb, 1); push(eax);                              /* push eax */
            ii(0x1007_f4cc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f4cf, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f4d2, 5); call(0x1008_a228, 0xad51);              /* call 0x1008a228 */
            ii(0x1007_f4d7, 5); call(0x1008_a370, 0xae94);              /* call 0x1008a370 */
            ii(0x1007_f4dc, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1007_f4df, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_f4e2, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_f4e5, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1007_f4eb, 5); mov(eax, StringDefinitions.FrontalAttackOnSInII); /* mov eax, 0x101a01e5 */
            ii(0x1007_f4f0, 1); push(eax);                              /* push eax */
            ii(0x1007_f4f1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f4f4, 1); push(eax);                              /* push eax */
            ii(0x1007_f4f5, 5); call(Definitions.sys_sprintf, 0xe_6a07); /* call 0x10165f01 */
            ii(0x1007_f4fa, 3); add(esp, 0x14);                         /* add esp, 0x14 */
        l_0x1007_f4fd:
            ii(0x1007_f4fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f500, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_f503, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_f506, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f508, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_f509, 1); pop(edi);                               /* pop edi */
            ii(0x1007_f50a, 1); pop(esi);                               /* pop esi */
            ii(0x1007_f50b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_f50c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_f50d, 1); ret();                                  /* ret */
        }
    }
}
